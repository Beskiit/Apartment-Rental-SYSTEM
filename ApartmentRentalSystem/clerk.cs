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
    public partial class clerk : Form
    {
        public clerk()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel5.Controls.Clear();
            panel5.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void dashboardIcon_Click(object sender, EventArgs e)
        {
            clerkDashboardScreen cds = new clerkDashboardScreen();
            addUserControl(cds);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void unitsIcon_Click(object sender, EventArgs e)
        {
            clerkUnitScreen cus = new clerkUnitScreen();
            addUserControl(cus);
        }

        private void tenantIcon_Click(object sender, EventArgs e)
        {
            clerkTenantScreen cts = new clerkTenantScreen();
            addUserControl(cts);
        }

        private void paymentIcon_Click(object sender, EventArgs e)
        {
            clerkPaymentScreen cps = new clerkPaymentScreen();
            addUserControl(cps);
        }

        private void clerk_Load(object sender, EventArgs e)
        {
            clerkDashboardScreen cds = new clerkDashboardScreen();
            addUserControl(cds);
        }
    }
}
