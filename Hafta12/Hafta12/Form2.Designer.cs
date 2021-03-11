namespace Hafta12
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabelCPU = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabelRAM = new MetroFramework.Controls.MetroLabel();
            this.chartBilgisayar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.performanceCounterCPU = new System.Diagnostics.PerformanceCounter();
            this.performanceCounterRAM = new System.Diagnostics.PerformanceCounter();
            this.timerIslem = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartBilgisayar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CPU :";
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(100, 89);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(334, 23);
            this.metroProgressBarCPU.TabIndex = 1;
            // 
            // metroLabelCPU
            // 
            this.metroLabelCPU.AutoSize = true;
            this.metroLabelCPU.Location = new System.Drawing.Point(460, 92);
            this.metroLabelCPU.Name = "metroLabelCPU";
            this.metroLabelCPU.Size = new System.Drawing.Size(41, 19);
            this.metroLabelCPU.TabIndex = 2;
            this.metroLabelCPU.Text = "0.0 %";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(37, 139);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "RAM";
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(100, 139);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(334, 23);
            this.metroProgressBarRAM.TabIndex = 4;
            // 
            // metroLabelRAM
            // 
            this.metroLabelRAM.AutoSize = true;
            this.metroLabelRAM.Location = new System.Drawing.Point(460, 139);
            this.metroLabelRAM.Name = "metroLabelRAM";
            this.metroLabelRAM.Size = new System.Drawing.Size(41, 19);
            this.metroLabelRAM.TabIndex = 5;
            this.metroLabelRAM.Text = "0.0 %";
            // 
            // chartBilgisayar
            // 
            this.chartBilgisayar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartBilgisayar.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartBilgisayar.Legends.Add(legend1);
            this.chartBilgisayar.Location = new System.Drawing.Point(37, 191);
            this.chartBilgisayar.Name = "chartBilgisayar";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            series2.YValuesPerPoint = 2;
            this.chartBilgisayar.Series.Add(series1);
            this.chartBilgisayar.Series.Add(series2);
            this.chartBilgisayar.Size = new System.Drawing.Size(490, 260);
            this.chartBilgisayar.TabIndex = 6;
            this.chartBilgisayar.Text = "chart1";
            // 
            // performanceCounterCPU
            // 
            this.performanceCounterCPU.CategoryName = "Processor";
            this.performanceCounterCPU.CounterName = "% Processor Time";
            this.performanceCounterCPU.InstanceName = "_Total";
            // 
            // performanceCounterRAM
            // 
            this.performanceCounterRAM.CategoryName = "Memory";
            this.performanceCounterRAM.CounterName = "% Committed Bytes In Use";
            // 
            // timerIslem
            // 
            this.timerIslem.Interval = 1000;
            this.timerIslem.Tick += new System.EventHandler(this.timerIslem_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 490);
            this.Controls.Add(this.chartBilgisayar);
            this.Controls.Add(this.metroLabelRAM);
            this.Controls.Add(this.metroProgressBarRAM);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabelCPU);
            this.Controls.Add(this.metroProgressBarCPU);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form2";
            this.Text = "CPU && RAM";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartBilgisayar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroLabel metroLabelCPU;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private MetroFramework.Controls.MetroLabel metroLabelRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBilgisayar;
        private System.Diagnostics.PerformanceCounter performanceCounterCPU;
        private System.Diagnostics.PerformanceCounter performanceCounterRAM;
        private System.Windows.Forms.Timer timerIslem;
    }
}