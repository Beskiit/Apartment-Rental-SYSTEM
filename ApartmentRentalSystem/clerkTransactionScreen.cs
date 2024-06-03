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
    public partial class clerkTransactionScreen : UserControl
    {
        public clerkTransactionScreen()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want add?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Added Successfully!");
            }
            else
            {
                MessageBox.Show("You pressed Cancel!");
            }
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
    }
}
