namespace HeatFromPhotovoltaics
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pvPeakkW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.heatPumpMaxkW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heatPumpEfficienceFactor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.heatPumpHighTemperature = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.heatPumpMinkW = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pvPeakkW
            // 
            this.pvPeakkW.Location = new System.Drawing.Point(460, 13);
            this.pvPeakkW.Name = "pvPeakkW";
            this.pvPeakkW.Size = new System.Drawing.Size(100, 22);
            this.pvPeakkW.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peak-Leistung Photovoltaik (kW):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // heatPumpMaxkW
            // 
            this.heatPumpMaxkW.Location = new System.Drawing.Point(460, 71);
            this.heatPumpMaxkW.Name = "heatPumpMaxkW";
            this.heatPumpMaxkW.Size = new System.Drawing.Size(100, 22);
            this.heatPumpMaxkW.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wärmepumpe max. elektrische Leistungsaufnahme (kW):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // heatPumpEfficienceFactor
            // 
            this.heatPumpEfficienceFactor.Location = new System.Drawing.Point(460, 99);
            this.heatPumpEfficienceFactor.Name = "heatPumpEfficienceFactor";
            this.heatPumpEfficienceFactor.Size = new System.Drawing.Size(100, 22);
            this.heatPumpEfficienceFactor.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Wärmepumpe Effizienzfaktor (typisch 0.5) (0.0 bis 1.0):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // heatPumpHighTemperature
            // 
            this.heatPumpHighTemperature.Location = new System.Drawing.Point(460, 127);
            this.heatPumpHighTemperature.Name = "heatPumpHighTemperature";
            this.heatPumpHighTemperature.Size = new System.Drawing.Size(100, 22);
            this.heatPumpHighTemperature.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Wärmepumpe Zieltemperatur (°C):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(460, 155);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(9, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Batterie Kapazität (kWh):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(460, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(9, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(442, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Batterie max LadeLeistung(kW):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // heatPumpMinkW
            // 
            this.heatPumpMinkW.Location = new System.Drawing.Point(460, 41);
            this.heatPumpMinkW.Name = "heatPumpMinkW";
            this.heatPumpMinkW.Size = new System.Drawing.Size(100, 22);
            this.heatPumpMinkW.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(9, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(442, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Wärmepumpe min. elektrische Leistungsaufnahme (kW):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(566, 302);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(95, 23);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Berechnen";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(566, 273);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(95, 23);
            this.saveFile.TabIndex = 3;
            this.saveFile.Text = "Speichern";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(15, 273);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(545, 206);
            this.result.TabIndex = 4;
            this.result.Text = "Berechnen drücken!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ergebnis:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(9, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(442, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Batterie maximale Entladeleistung (kW):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(460, 239);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Location = new System.Drawing.Point(9, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(442, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "Batterie Effizienz (%):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 491);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.result);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.heatPumpHighTemperature);
            this.Controls.Add(this.heatPumpEfficienceFactor);
            this.Controls.Add(this.heatPumpMaxkW);
            this.Controls.Add(this.heatPumpMinkW);
            this.Controls.Add(this.pvPeakkW);
            this.Name = "Form1";
            this.Text = "Berechnung Wärmeanteil einer Freiflächen Photovoltaik Anlage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pvPeakkW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heatPumpMaxkW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heatPumpEfficienceFactor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox heatPumpHighTemperature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox heatPumpMinkW;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
    }
}

