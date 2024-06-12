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
    public partial class adminDashboardScreen : UserControl
    {
        public adminDashboardScreen()
        {
            InitializeComponent();
        }
        private void adminDashboardScreen_Load_1(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

        }

    }
}