using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Room WHERE status = 'Occupied'", Connection.conn);
            int occupiedCount = Convert.ToInt32(cmd.ExecuteScalar());
            cmd = new SqlCommand("SELECT COUNT(*) FROM Room WHERE status = 'Vacant'", Connection.conn);
            int freeCount = Convert.ToInt32(cmd.ExecuteScalar());

            UpdateChart(occupiedCount, freeCount);
            Connection.conn.Close();
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


        private void adminDashboardScreen_Load_1(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void viewDetailsUnits_Click(object sender, EventArgs e)
        {

        }

        private void viewDetailsTenants_Click(object sender, EventArgs e)
        {
            adminTenantScreen ats = new adminTenantScreen();
            
        }

        private void ViewDetailsPayments_Click(object sender, EventArgs e)
        {

        }

        private void viewDetailsUsers_Click(object sender, EventArgs e)
        {

        }
    }
}