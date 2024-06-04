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
    public partial class adminUpdateTransaction : UserControl
    {
        public adminUpdateTransaction()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want updat?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show("Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("You pressed Cancel!");
                    Connection.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updating transaction failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }


        }
    }
}
