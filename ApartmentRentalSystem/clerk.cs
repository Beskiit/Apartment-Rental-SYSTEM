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
      
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void dashboardIcon_Click(object sender, EventArgs e)
        {
            clerkDashboardScreen cds = new clerkDashboardScreen();
            addUserControl(cds);
            panel3.Height = dashboardIcon.Height;
            panel3.Top = dashboardIcon.Top;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void unitsIcon_Click(object sender, EventArgs e)
        {
            clerkUnitScreen cus = new clerkUnitScreen();
            addUserControl(cus);
            panel3.Height = unitsIcon.Height;
            panel3.Top = unitsIcon.Top;
        }

        private void tenantIcon_Click(object sender, EventArgs e)
        {
            clerkTenantScreen cts = new clerkTenantScreen();
            addUserControl(cts);
            panel3.Height = tenantIcon.Height;
            panel3.Top = tenantIcon.Top;
        }

        private void paymentIcon_Click(object sender, EventArgs e)
        {
            clerkPaymentScreen cps = new clerkPaymentScreen();
            addUserControl(cps);
            panel3.Height = paymentIcon.Height;
            panel3.Top = paymentIcon.Top;
        }

        private void clerk_Load(object sender, EventArgs e)
        {
            clerkDashboardScreen cds = new clerkDashboardScreen();
            addUserControl(cds);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();
                loginForm.Show();
                this.Close();

            }
        }

        private void clerkDashboardScreen1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clerkTransactionScreen clerkTransactionScreen = new clerkTransactionScreen();
            addUserControl(clerkTransactionScreen);
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
        }
    }
}
