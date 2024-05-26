namespace ApartmentRentalSystem
{
    partial class adminDashboardScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pieChartUnit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChartUnit
            // 
            this.pieChartUnit.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.pieChartUnit.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChartUnit.Legends.Add(legend1);
            this.pieChartUnit.Location = new System.Drawing.Point(43, 73);
            this.pieChartUnit.Name = "pieChartUnit";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChartUnit.Series.Add(series1);
            this.pieChartUnit.Size = new System.Drawing.Size(305, 334);
            this.pieChartUnit.TabIndex = 0;
            this.pieChartUnit.Text = "chart1";
            // 
            // adminDashboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pieChartUnit);
            this.Name = "adminDashboardScreen";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.pieChartUnit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartUnit;
    }
}
