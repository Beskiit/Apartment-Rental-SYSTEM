using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ApartmentRentalSystem
{
    public partial class adminDashboardScreen : UserControl
    {
        public adminDashboardScreen()
        {
            InitializeComponent();
            this.Load += new EventHandler(adminDashboardScreen_Load);
        }
        private void adminDashboardScreen_Load(object sender, EventArgs e)
        {
            LoadRentalStatus();
        }

        private void LoadRentalStatus()
        {
            int occupiedCount = 3;
            int freeCount = 2;

            UpdateChart(occupiedCount, freeCount);
        }
        private void UpdateChart(int available, int occupied)
        {
            pieChartUnit.Series.Clear();
            pieChartUnit.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea();
            pieChartUnit.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "RentalStatus",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };

            pieChartUnit.Series.Add(series);

            series.Points.Add(available);
            series.Points[0].Label = "Available";

            series.Points.Add(occupied);
            series.Points[1].Label = "Occupied";

            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";
            series.Points[0]["Exploded"] = "true";
            series.Points[0].Color = System.Drawing.Color.LightGreen;
            series.Points[1].Color = System.Drawing.Color.Red;

            pieChartUnit.Size = new System.Drawing.Size(350,350);
        }
    }
}