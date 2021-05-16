
namespace Radiales
{
    partial class Graficador
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LbMenor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grafica1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LbIntentos = new System.Windows.Forms.Label();
            this.LbErrorPor = new System.Windows.Forms.Label();
            this.LbPorcentaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grafica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // LbMenor
            // 
            this.LbMenor.AutoSize = true;
            this.LbMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbMenor.ForeColor = System.Drawing.SystemColors.Control;
            this.LbMenor.Location = new System.Drawing.Point(594, 62);
            this.LbMenor.Name = "LbMenor";
            this.LbMenor.Size = new System.Drawing.Size(18, 20);
            this.LbMenor.TabIndex = 22;
            this.LbMenor.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(498, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Menor error : ";
            // 
            // LbError
            // 
            this.LbError.AutoSize = true;
            this.LbError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbError.ForeColor = System.Drawing.SystemColors.Control;
            this.LbError.Location = new System.Drawing.Point(548, 30);
            this.LbError.Name = "LbError";
            this.LbError.Size = new System.Drawing.Size(18, 20);
            this.LbError.TabIndex = 20;
            this.LbError.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(498, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Error : ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(439, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Error Obtenido vs Goal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grafica1
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.Name = "ChartArea1";
            this.grafica1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.grafica1.Legends.Add(legend3);
            this.grafica1.Location = new System.Drawing.Point(32, 146);
            this.grafica1.Name = "grafica1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.grafica1.Series.Add(series3);
            this.grafica1.Size = new System.Drawing.Size(439, 256);
            this.grafica1.TabIndex = 27;
            this.grafica1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LineColor = System.Drawing.SystemColors.WindowFrame;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(502, 146);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(439, 256);
            this.chart2.TabIndex = 28;
            this.chart2.Text = "chart1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Error YD vs YR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(31, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Intentos : ";
            // 
            // LbIntentos
            // 
            this.LbIntentos.AutoSize = true;
            this.LbIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbIntentos.ForeColor = System.Drawing.SystemColors.Control;
            this.LbIntentos.Location = new System.Drawing.Point(127, 30);
            this.LbIntentos.Name = "LbIntentos";
            this.LbIntentos.Size = new System.Drawing.Size(18, 20);
            this.LbIntentos.TabIndex = 30;
            this.LbIntentos.Text = "?";
            // 
            // LbErrorPor
            // 
            this.LbErrorPor.AutoSize = true;
            this.LbErrorPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbErrorPor.ForeColor = System.Drawing.SystemColors.Control;
            this.LbErrorPor.Location = new System.Drawing.Point(127, 62);
            this.LbErrorPor.Name = "LbErrorPor";
            this.LbErrorPor.Size = new System.Drawing.Size(18, 20);
            this.LbErrorPor.TabIndex = 33;
            this.LbErrorPor.Text = "?";
            // 
            // LbPorcentaje
            // 
            this.LbPorcentaje.AutoSize = true;
            this.LbPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LbPorcentaje.ForeColor = System.Drawing.SystemColors.Control;
            this.LbPorcentaje.Location = new System.Drawing.Point(31, 62);
            this.LbPorcentaje.Name = "LbPorcentaje";
            this.LbPorcentaje.Size = new System.Drawing.Size(80, 20);
            this.LbPorcentaje.TabIndex = 32;
            this.LbPorcentaje.Text = "Error (%): ";
            // 
            // Graficador
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(975, 439);
            this.ControlBox = false;
            this.Controls.Add(this.LbErrorPor);
            this.Controls.Add(this.LbPorcentaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbIntentos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbMenor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbError);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grafica1);
            this.Controls.Add(this.chart2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Graficador";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generalizador";
            ((System.ComponentModel.ISupportInitialize)(this.grafica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbMenor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataVisualization.Charting.Chart grafica1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbIntentos;
        private System.Windows.Forms.Label LbErrorPor;
        private System.Windows.Forms.Label LbPorcentaje;
    }
}