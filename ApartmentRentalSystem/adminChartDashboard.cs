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
            string[] units = { "Available", "Occupied", "Not Available" };

            chart.Legend.Position = Guna.Charts.WinForms.LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            var dataset = new Guna.Charts.WinForms.GunaPieDataset();
            var r = new Random();
            for (int i = 0; i < units.Length; i++)
            {
                int num = r.Next(10, 100);

                dataset.DataPoints.Add(units[i], num);
            }

            chart.Datasets.Add(dataset);
            chart.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Add(chart);
            chart.Update();

        }

    }
    }
   

