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

namespace ApartmentRentalSystem
{
    public partial class admin : Form
    {

        public admin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

        }



        private bool isExitConfirmed = false;

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isExitConfirmed)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    isExitConfirmed = true;
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        private void admin_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(admin_FormClosing);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        
 
        }

        private void dashboardIcon_Click(object sender, EventArgs e)
        {
            adminDashboardScreen ads = new adminDashboardScreen();
            addUserControl(ads);
            panel3.Height = dashboardIcon.Height;
            panel3.Top = dashboardIcon.Top;
        }

        private void unitsIcon_Click(object sender, EventArgs e)
        {
            adminUnitScreen aus = new adminUnitScreen();
            addUserControl(aus);
            panel3.Height = unitsIcon.Height;
            panel3.Top = unitsIcon.Top;
        }

        private void tenantIcon_Click(object sender, EventArgs e)
        {
            adminTenantScreen ats = new adminTenantScreen();
            addUserControl(ats);
            panel3.Height = tenantIcon.Height;
            panel3.Top = tenantIcon.Top;
        }

        private void paymentIcon_Click(object sender, EventArgs e)
        {
            adminPaymentScreen aps = new adminPaymentScreen();
            addUserControl(aps);
            panel3.Height = paymentIcon.Height;
            panel3.Top = paymentIcon.Top;
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
        private void button1_Click(object sender, EventArgs e)
        {
            adminTransactionScreen adminTransactionScreen = new adminTransactionScreen();
            addUserControl(adminTransactionScreen);
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
        }

        private void Lease_Click(object sender, EventArgs e)
        {
            adminLeaseScreen adminLeaseScreen = new adminLeaseScreen();
            addUserControl(adminLeaseScreen);
            panel3.Height = Lease.Height;
            panel3.Top = Lease.Top;
        }
    }
}