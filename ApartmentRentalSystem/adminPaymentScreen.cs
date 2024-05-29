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
        
            admin bigForm = Application.OpenForms.OfType<admin>().FirstOrDefault();

            if (bigForm != null)
            {
    
                bigForm.ShowOverlay();


                adminAddTransactionForm adminAddTransactionForm = new adminAddTransactionForm();
                adminAddTransactionForm.FormClosed += (s, args) => bigForm.HideOverlay();
                adminAddTransactionForm.ShowDialog(bigForm); 
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminPaymentScreen_Load(object sender, EventArgs e)
        {

        }

        private void backPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
