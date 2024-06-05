namespace ApartmentRentalSystem
{
    partial class clerkDashboardScreen
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.pieChartUnit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(967, 22);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(227, 28);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "label7";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pieChartUnit
            // 
            this.pieChartUnit.BackColor = System.Drawing.Color.Transparent;
            this.pieChartUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pieChartUnit.BorderlineColor = System.Drawing.Color.Transparent;
            this.pieChartUnit.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.pieChartUnit.BorderSkin.BorderWidth = 2;
            this.pieChartUnit.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.pieChartUnit.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChartUnit.Legends.Add(legend1);
            this.pieChartUnit.Location = new System.Drawing.Point(90, 0);
            this.pieChartUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pieChartUnit.Name = "pieChartUnit";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChartUnit.Series.Add(series1);
            this.pieChartUnit.Size = new System.Drawing.Size(640, 559);
            this.pieChartUnit.TabIndex = 18;
            this.pieChartUnit.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "UNITS";
            // 
            // clerkDashboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pieChartUnit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "clerkDashboardScreen";
            this.Size = new System.Drawing.Size(1267, 738);
            this.Load += new System.EventHandler(this.clerkDashboardScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pieChartUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartUnit;
        private System.Windows.Forms.Label label7;
    }
}
