using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class adminPaymentScreen : UserControl
    {
        public adminPaymentScreen()
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
            adminAddPayment adminAddPayment = new adminAddPayment();
            addUserControl(adminAddPayment);

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminUpdatePayment adminUpdatePayment = new adminUpdatePayment();
            addUserControl (adminUpdatePayment);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           adminDeletePayment adminDeletePayment = new adminDeletePayment();
            addUserControl(adminDeletePayment);
        }
    }
}
