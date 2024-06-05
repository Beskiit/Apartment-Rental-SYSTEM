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
    public partial class adminaddUnit : UserControl
    {
        public adminaddUnit()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Room (roomNumber, description, price, status) VALUES (@roomNumber, @description, @price, @status)", Connection.conn);
                if (MessageBox.Show("Are you sure you want add?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    cmd.Parameters.AddWithValue("@roomNumber", Convert.ToInt32(roomNumberBox.Text));
                    cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(amountBox.Text));
                    cmd.Parameters.AddWithValue("@status", "vacant");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!");
                }
                else
                {
                    MessageBox.Show("You pressed Cancel!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding unit failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
        }

        private void roomNumberBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
