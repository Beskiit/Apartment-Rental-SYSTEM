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
    public partial class clerkDashboardScreen : UserControl
    {
        public clerkDashboardScreen()
        {
            InitializeComponent();
        }
        
        private void viewDetailsTenants_Click(object sender, EventArgs e)
        { 
            clerk c = new clerk();
            clerkTenantScreen cts = new clerkTenantScreen();
            c.addUserControl(cts);
        }
    }
}
