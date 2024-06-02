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
    public partial class adminTenantScreen : UserControl
    {
        private addTenant1 addControl;
        private addTenant addTenantControl;

        public adminTenantScreen()
        {
            InitializeComponent();
        }

        private void ShowAddControl()
        {
            addControl.Visible = true;
            addTenantControl.Visible = false;
        }

        private void ShowAddTenantControl()
        {
            addControl.Visible = false;
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
    }
}