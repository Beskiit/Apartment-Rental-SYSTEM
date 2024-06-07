namespace ApartmentRentalSystem
{
    partial class adminChartDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.Charts.WinForms.ChartFont chartFont17 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont18 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont19 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont20 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid7 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick7 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont21 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid8 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick8 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont22 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid9 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel3 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont23 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick9 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont24 = new Guna.Charts.WinForms.ChartFont();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.gunaChart1 = new Guna.Charts.WinForms.GunaChart();
            this.lineChart = new Guna.Charts.WinForms.GunaLineDataset();
            this.chartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPanel
            // 
            this.chartPanel.Controls.Add(this.gunaChart1);
            this.chartPanel.Location = new System.Drawing.Point(0, 0);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(748, 278);
            this.chartPanel.TabIndex = 20;
            // 
            // gunaChart1
            // 
            this.gunaChart1.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.lineChart});
            chartFont17.FontName = "Arial";
            this.gunaChart1.Legend.LabelFont = chartFont17;
            this.gunaChart1.Location = new System.Drawing.Point(0, 0);
            this.gunaChart1.Name = "gunaChart1";
            this.gunaChart1.Size = new System.Drawing.Size(748, 278);
            this.gunaChart1.TabIndex = 0;
            chartFont18.FontName = "Arial";
            chartFont18.Size = 12;
            chartFont18.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Title.Font = chartFont18;
            chartFont19.FontName = "Arial";
            this.gunaChart1.Tooltips.BodyFont = chartFont19;
            chartFont20.FontName = "Arial";
            chartFont20.Size = 9;
            chartFont20.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.gunaChart1.Tooltips.TitleFont = chartFont20;
            this.gunaChart1.XAxes.GridLines = grid7;
            chartFont21.FontName = "Arial";
            tick7.Font = chartFont21;
            this.gunaChart1.XAxes.Ticks = tick7;
            this.gunaChart1.YAxes.GridLines = grid8;
            chartFont22.FontName = "Arial";
            tick8.Font = chartFont22;
            this.gunaChart1.YAxes.Ticks = tick8;
            this.gunaChart1.ZAxes.GridLines = grid9;
            chartFont23.FontName = "Arial";
            pointLabel3.Font = chartFont23;
            this.gunaChart1.ZAxes.PointLabels = pointLabel3;
            chartFont24.FontName = "Arial";
            tick9.Font = chartFont24;
            this.gunaChart1.ZAxes.Ticks = tick9;
            // 
            // lineChart
            // 
            this.lineChart.BorderColor = System.Drawing.Color.Empty;
            this.lineChart.FillColor = System.Drawing.Color.Empty;
            this.lineChart.Label = "Line1";
            this.lineChart.TargetChart = this.gunaChart1;
            // 
            // adminChartDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartPanel);
            this.Name = "adminChartDashboard";
            this.Size = new System.Drawing.Size(847, 281);
            this.chartPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel chartPanel;
        private Guna.Charts.WinForms.GunaChart gunaChart1;
        private Guna.Charts.WinForms.GunaLineDataset lineChart;
    }
}
