using Guna.Charts.WinForms;
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
    public partial class adminChartDashboard : UserControl
    {
        public adminChartDashboard()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            string[] units = { "Vacant", "Occupied", "Not Available(Under Maintenance)" };

            chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            var dataset = new Guna.Charts.WinForms.GunaPieDataset
            {
                Label = "Room Status"
            };

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True"))
            {
                conn.Open();

                for (int i = 0; i < units.Length; i++)
                {
                    int num = 0;
                    string status = units[i];

                    string query = "SELECT COUNT(*) FROM [Room] WHERE status = @status";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        num = (int)cmd.ExecuteScalar();
                    }

                    dataset.DataPoints.Add(status, num);
                }
            }

            chart.Datasets.Add(dataset);
            chart.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Add(chart);
            chart.Update();
        }

    }

}
   

