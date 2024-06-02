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

        private void ShowAddControl()
        {
            addTenantControl.Visible = false;
        }

        private void ShowAddTenantControl()
        {
            addTenantControl.Visible = true;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddControl();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddTenantControl();
        }

        private void addTenant1_Load(object sender, EventArgs e)
        {

        }

        private void adminTenantScreen_Load(object sender, EventArgs e)
        {

        }
    }
}