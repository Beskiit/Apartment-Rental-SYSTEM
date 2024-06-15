using Guna.Charts.WinForms;
using Guna.UI2.WinForms;
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
            InitializeChart();
        }

        private void InitializeChart()
        {
            string[] units = { "Vacant", "Occupied", "Not Available(Under Maintenance)" };

            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            var dataset = new Guna.Charts.WinForms.GunaPieDataset
            {
                Label = "Room status"
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

            chart.Update();
        }

public class Connection
        {
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
        }

        private void adminDashboardScreen_Load_1(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            showTenant();
            showVacant();
            showOccupied();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void showTenant()
        {
            Connection.conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Tenant",Connection.conn);
            
            tenantLabel.Text = cmd.ExecuteScalar().ToString();
            Connection.conn.Close();
        }

        private void showVacant()
        {
            Connection.conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Room WHERE status = 'Vacant'", Connection.conn);

            unitLabel.Text = cmd.ExecuteScalar().ToString();
            Connection.conn.Close();
        }

        private void showOccupied()
        {
            Connection.conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Room WHERE status = 'Occupied'", Connection.conn);

            occuLabel.Text = cmd.ExecuteScalar().ToString();
            Connection.conn.Close();
        }

    }
}