using Guna.Charts.WinForms;
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
    public partial class clerkChartDashboard : UserControl
    {
        public clerkChartDashboard()
        {
            InitializeComponent();
                InitializeChart();
            }

            private void InitializeChart()
            {

                string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

                gunaChart1.YAxes.GridLines.Display = false;

                var dataset = new Guna.Charts.WinForms.GunaLineDataset();
                dataset.PointRadius = 5;
                dataset.PointStyle = PointStyle.Circle;
                var r = new Random();
                for (int i = 0; i < months.Length; i++)
                {
                    int num = r.Next(1, 10);

                    dataset.DataPoints.Add(months[i], num);
                }


                gunaChart1.Datasets.Add(dataset);
                gunaChart1.Update();

            }
        }
}
