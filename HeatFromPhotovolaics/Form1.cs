using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatFromPhotovoltaics
{
    public partial class Form1 : Form
    {
        private double[] Temperature;
        private double[] GlobalSolarRadiation;
        private double[] DiffuseRadiation;
        private StringBuilder csvText = new StringBuilder();
        const double ZeroK = 273.15;

        public Form1()
        {
            InitializeComponent();
            pvPeakkW.Text = "900";
            heatPumpMinkW.Text = "50";
            heatPumpMaxkW.Text = "200";
            heatPumpHighTemperature.Text = "50";
            heatPumpEfficienceFactor.Text = "0.5";
        }
        /// <summary>
        /// Converts a date to the number of the hour in the year [0..8759]
        /// </summary>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <param name="hour"></param>
        /// <returns></returns>
        internal static int DateToHourNumber(int month, int day, int hour)
        {   // don't care about leap year
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int res = 0;
            for (int i = 1; i < month; i++)
            {
                res += 24 * months[i - 1];
            }
            res += (day - 1) * 24 + hour;
            return res;
        }

        public static Dictionary<int, double[]> ReadDwdData(StreamReader reader, string column)
        {
            Dictionary<int, double[]> yearToData = new Dictionary<int, double[]>();
            string line = reader.ReadLine();
            if (line != null)
            {
                string[] title = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                int dateIndex = -1, valueIndex = -1;
                for (int i = 0; i < title.Length; i++)
                {
                    if (title[i].Contains("MESS_DATUM")) dateIndex = i;
                    if (title[i].Contains(column)) valueIndex = i;
                }
                if (dateIndex >= 0 && valueIndex >= 0)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length > dateIndex && parts.Length > valueIndex)
                        {
                            string date = parts[dateIndex];
                            if (date.Length >= 10)
                            {
                                try
                                {
                                    int year = Convert.ToInt32(date.Substring(0, 4));
                                    int month = Convert.ToInt32(date.Substring(4, 2));
                                    int day = Convert.ToInt32(date.Substring(6, 2));
                                    int hour = Convert.ToInt32(date.Substring(8, 2));
                                    if (year > 1800 && year < 2050 && month > 0 && month <= 12 && day > 0 && day <= 31 && hour >= 0 && hour < 24)
                                    {
                                        if (!yearToData.TryGetValue(year, out double[] valuePerHour))
                                        {
                                            yearToData[year] = valuePerHour = new double[8760];
                                            for (int i = 0; i < valuePerHour.Length; i++)
                                            {
                                                valuePerHour[i] = 0;
                                            }
                                        }
                                        int hn = DateToHourNumber(month, day, hour);
                                        valuePerHour[hn] = Convert.ToDouble(parts[valueIndex], CultureInfo.InvariantCulture);
                                        if (valuePerHour[hn] == -999 && hn > 24) valuePerHour[hn] = valuePerHour[hn - 24]; 
                                        // -999 is an error in data, lets use the data of the day before
                                    }
                                }
                                catch { }
                            }
                        }
                    }
                }
            }
            return yearToData;
        }
        private void ReadClimateData()
        {
            Assembly ThisAssembly = Assembly.GetExecutingAssembly();
            string[] dbg = ThisAssembly.GetManifestResourceNames();
            System.IO.Stream str = ThisAssembly.GetManifestResourceStream("HeatFromPhotovoltaics.produkt_tu_stunde_Potsdam.txt");
            if (str != null)
            {
                using (StreamReader reader = new StreamReader(str))
                {
                    Dictionary<int, double[]> dwdData = ReadDwdData(reader, "TT_TU");
                    if (dwdData.Any()) Temperature = dwdData.First().Value;
                }
            }
            str = ThisAssembly.GetManifestResourceStream("HeatFromPhotovoltaics.produkt_st_stunde_Potsdam.txt");
            if (str != null)
            {
                using (StreamReader reader = new StreamReader(str))
                {
                    Dictionary<int, double[]> dwdData = ReadDwdData(reader, "FG_LBERG");
                    if (dwdData.Any()) GlobalSolarRadiation = dwdData.First().Value;
                }
                str = ThisAssembly.GetManifestResourceStream("HeatFromPhotovoltaics.produkt_st_stunde_Potsdam.txt");
                using (StreamReader reader = new StreamReader(str))
                {
                    Dictionary<int, double[]> dwdData = ReadDwdData(reader, "FD_LBERG");
                    if (dwdData.Any()) DiffuseRadiation = dwdData.First().Value;
                }
            }
            // Testcode zur Bestimmung der Skalierung der Strahlung auf kW Leistung:
            double sum = 0.0;
            double maxRad = 0.0;
            double smax = 0;
            for (int i = 0; i < GlobalSolarRadiation.Length; i++)
            {
                if (GlobalSolarRadiation[i] > maxRad) maxRad = GlobalSolarRadiation[i];
                double s = Math.Pow((GlobalSolarRadiation[i] / 350), 1.2) * 1.05;
                smax = Math.Max(smax, s);
                if (GlobalSolarRadiation[i] >= 0) sum += s; // experimtell bestimmter Wert
                else { }
            }
            double f = 1000 / sum;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            ReadClimateData();
            double.TryParse(pvPeakkW.Text.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out double peak);
            double.TryParse(heatPumpMinkW.Text.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out double heatPumpMin);
            double.TryParse(heatPumpMaxkW.Text.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out double heatPumpMax);
            double.TryParse(heatPumpHighTemperature.Text.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out double heatPumpTemp);
            double.TryParse(heatPumpEfficienceFactor.Text.Replace(",", "."), NumberStyles.Float, CultureInfo.InvariantCulture, out double heatPumpEF);
            double usedForHeatPump = 0.0, notUsed = 0.0, totalElectric = 0.0, totalHeat = 0.0, sumCop = 0.0;
            int hCop = 0;
            for (int i = 0; i < GlobalSolarRadiation.Length; i++)
            {
                double kW = Math.Pow((GlobalSolarRadiation[i] / 350), 1.2) * 1.05; // gering nichtlieares Verhalten
                kW *= peak;

                if (kW < heatPumpMin) notUsed += kW;
                else if (kW < heatPumpMax) usedForHeatPump += kW;
                else
                {
                    notUsed += kW - heatPumpMax;
                    usedForHeatPump += heatPumpMax;
                }
                double heat = 0.0;
                double cop = heatPumpEF * (heatPumpTemp + ZeroK) / (heatPumpTemp - Temperature[i]); // Carnot Wirkungsgrad * Güte
                if (kW > heatPumpMin && kW < heatPumpMax)
                {
                    heat = cop * kW;
                    ++hCop;
                    sumCop += cop;
                }
                else if (kW > heatPumpMax)
                {
                    heat = cop * heatPumpMax;
                    ++hCop;
                    sumCop += cop;
                }
                totalElectric += kW;
                totalHeat += heat;
                csvText.AppendLine(i.ToString() + ", " + kW.ToString("F2", CultureInfo.InvariantCulture) + ", " 
                    + heat.ToString("F2", CultureInfo.InvariantCulture) + ", "
                    + (kW-heat/cop).ToString("F2", CultureInfo.InvariantCulture) + ", "
                    + cop.ToString("F2", CultureInfo.InvariantCulture) + ", "
                    + Temperature[i].ToString("F1", CultureInfo.InvariantCulture));
            }
            result.Text = "elektrische Gesamtleistung: " + (totalElectric / 1000).ToString("F3", CultureInfo.InvariantCulture) + " MWh\r\n"
                + "erzeugte Wärme: " + (totalHeat / 1000).ToString("F3", CultureInfo.InvariantCulture) + " MWh\r\n"
                + "Strom verwendet für Wärme: " + (usedForHeatPump / 1000).ToString("F3", CultureInfo.InvariantCulture) + " MWh\r\n"
                + "nicht genutzter Strom: " + (notUsed / 1000).ToString("F3", CultureInfo.InvariantCulture) + " MWh\r\n"
                + "durchschnittlicher COP: " + (sumCop / hCop).ToString("F2", CultureInfo.InvariantCulture) + " \r\n";
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(saveFileDialog.FileName))
                {
                    outputFile.WriteLine("Stunde,elektrische_Leistung,Wärmeleistung,elektrischer_Überschuss,COP,Umgebungstemperatur");
                    outputFile.WriteLine(csvText.ToString());
                }
            }
        }
    }
}
