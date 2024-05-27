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
    public partial class adminPaymentScreen : UserControl
    {
        public adminPaymentScreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Find the main form
            admin bigForm = Application.OpenForms.OfType<admin>().FirstOrDefault();

            if (bigForm != null)
            {
                // Show the overlay form
                bigForm.ShowOverlay();

                // Show the adminAddTransactionForm as a dialog on top of the overlay
                adminAddTransactionForm adminAddTransactionForm = new adminAddTransactionForm();
                adminAddTransactionForm.FormClosed += (s, args) => bigForm.HideOverlay();
                adminAddTransactionForm.ShowDialog(bigForm); // Use ShowDialog with owner
            }
        }
    }
}
