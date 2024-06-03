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
    public partial class adminUnitScreen : UserControl
    {
        public adminUnitScreen()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void adminUnitScreen_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminaddUnit adminaddUnit = new adminaddUnit();
            addUserControl(adminaddUnit);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminUpdateUnit adminUpdateUnit = new adminUpdateUnit();
            addUserControl(adminUpdateUnit);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminDeleteUnit adminDeleteUnit = new adminDeleteUnit();
            addUserControl(adminDeleteUnit);
        }
    }
}
