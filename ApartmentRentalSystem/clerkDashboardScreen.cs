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
    public partial class clerkDashboardScreen : UserControl
    {
        public clerkDashboardScreen()
        {
            InitializeComponent();
            this.Load += new EventHandler(clerkDashboardScreen_Load);
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
      
    }
}
}
