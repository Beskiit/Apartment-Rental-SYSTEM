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
    public partial class adminUserScreen : UserControl
    {
        public adminUserScreen()
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
        private void adminUserScreen_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminAddUser adminAddUser = new adminAddUser();
            addUserControl(adminAddUser);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminUpdateUnit adminUpdateUnit = new adminUpdateUnit();
            addUserControl(adminUpdateUnit);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminDeletePayment adminDeletePayment = new adminDeletePayment();
            addUserControl (adminDeletePayment);
        }
    }
}
