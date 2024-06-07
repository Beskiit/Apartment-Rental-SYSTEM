using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class adminChartDashboardUser : UserControl
    {
        public adminChartDashboardUser()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            string[] user = { "Admin", "Clerk"};

            gunaChart1.YAxes.GridLines.Display = false;


            var dataset = new Guna.Charts.WinForms.GunaHorizontalBarDataset();
            var r = new Random();
            for (int i = 0; i < user.Length; i++)
            {

                int num = r.Next(1, 10);

                dataset.DataPoints.Add(user[i], num);
            }

            gunaChart1.Datasets.Add(dataset);
            gunaChart1.Update();
        }
    }
}
