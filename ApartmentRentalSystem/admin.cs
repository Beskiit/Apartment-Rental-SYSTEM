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
    public partial class admin : Form
    {
        private overlayForm overlayForm;

        public admin()
        {
            InitializeComponent();
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
        }

        private void unitsIcon_Click(object sender, EventArgs e)
        {
            adminUnitScreen aus = new adminUnitScreen();
            addUserControl(aus);
        }

        private void tenantIcon_Click(object sender, EventArgs e)
        {
            adminTenantScreen ats = new adminTenantScreen();
            addUserControl(ats);
        }

        private void paymentIcon_Click(object sender, EventArgs e)
        {
            adminPaymentScreen aps = new adminPaymentScreen();
            addUserControl(aps);
        }

        private void userIcon_Click(object sender, EventArgs e)
        {
            adminUserScreen ausers = new adminUserScreen();
            addUserControl(ausers);
        }

        private void adminDashboardScreen1_Load(object sender, EventArgs e)
        {
        }

        public void ShowOverlay()
        {
            overlayForm = new overlayForm();
            overlayForm.SetOwner(this);
            overlayForm.Show();
        }

        public void HideOverlay()
        {
            if (overlayForm != null)
            {
                overlayForm.Close();
                overlayForm = null;
            }
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
    }
}