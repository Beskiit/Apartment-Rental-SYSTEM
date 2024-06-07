using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class clerkTransactionScreen : UserControl
    {
        public clerkTransactionScreen()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void updateClerkTransaction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Updated Successfully!");
            }
            else
            {
                MessageBox.Show("You pressed Cancel!");
            }
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();


        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addPaymentClerk_Click(object sender, EventArgs e)
        {
            clerkAddTransaction cat  = new clerkAddTransaction();
            addUserControl(cat);
        }

        private void updatePaymentClerk_Click(object sender, EventArgs e)
        {
            clerkUpdateTransaction cut = new clerkUpdateTransaction();
            addUserControl(cut);
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
        }

        private void clerkTransactionScreen_Load(object sender, EventArgs e)
        {
           
        }
    }
}
