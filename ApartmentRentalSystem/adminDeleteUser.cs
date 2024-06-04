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
    public partial class adminDeleteUser : UserControl
    {
        public adminDeleteUser()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want delete?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("You pressed Cancel!");
            }


        }

        private void adminDeleteUser_Load(object sender, EventArgs e)
        {

        }
    }
}
