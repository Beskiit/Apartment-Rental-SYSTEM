using System;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class adminTenantScreen : UserControl
    {
        private addTenant addTenantControl;

        public adminTenantScreen()
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTenant addTenant = new addTenant();
            addUserControl(addTenant);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateTenant updateTenant = new updateTenant();
            addUserControl(updateTenant);
        }

        private void adminTenantScreen_Load(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteTenant deleteTenant = new deleteTenant();
            addUserControl(deleteTenant);
        }
    }
}