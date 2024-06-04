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
    public partial class clerkDashboardScreen : UserControl
    {
        public clerkDashboardScreen()
        {
            InitializeComponent();
            this.Load += new EventHandler(clerkDashboardScreen_Load);
        }
        private void LoadRentalStatus()
        {
            int occupiedCount = 17;
            int freeCount = 41;

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

            series.Points.AddXY("Available", available);
            series.Points[0].Label = "#VALY";
            series.Points[0].LegendText = "Available";
            series.Points[0].Font = new Font("Poppins", 10f, FontStyle.Regular);
            series.Points.AddXY("Occupied", occupied);
            series.Points[1].Label = "#VALY";
            series.Points[1].LegendText = "Occupied";
            series.Points[1].Font = new Font("Poppins", 10f, FontStyle.Regular);
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";
            series.Points[0]["Exploded"] = "true";
            series.Points[0].Color = Color.LightGreen;
            series.Points[1].Color = Color.Red;

            pieChartUnit.Size = new Size(450, 400);
            pieChartUnit.Legends[0].BackColor = Color.Transparent;
            pieChartUnit.ChartAreas[0].BackColor = Color.Transparent;
        }


        private void viewDetailsTenants_Click(object sender, EventArgs e)
        { 
            clerk c = new clerk();
            clerkTenantScreen cts = new clerkTenantScreen();
            c.addUserControl(cts);
        }

        private void clerkDashboardScreen_Load(object sender, EventArgs e)
    {
        dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        LoadRentalStatus();
    }
}
}
