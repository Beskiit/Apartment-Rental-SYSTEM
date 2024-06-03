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
    public partial class adminTransactionScreen : UserControl
    {
        public adminTransactionScreen()
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminAddTransaction adminAddTransaction = new adminAddTransaction();
            addUserControl(adminAddTransaction);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminUdateTransaction admin = new adminUdateTransaction();
            addUserControl (admin);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminDeleteTransaction adminDeleteTransaction = new adminDeleteTransaction();
            addUserControl(adminDeleteTransaction);
        }
    }
}
