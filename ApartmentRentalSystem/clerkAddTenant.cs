using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class clerkAddTenant : UserControl
    {
        public clerkAddTenant()
        {
            InitializeComponent();
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void updateTenantClerk_Click(object sender, EventArgs e)
        {

        }

        private void addTenantClerk_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addPaymentClerk_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tenant (firstName, lastName, phoneNum, email, unit) VALUES (@firstName, @lastName, @phoneNum, @email, @unit)", Connection.conn);
                if (Regex.IsMatch(numBox.Text, @"^[0-9]+$"))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
                    cmd.Parameters.AddWithValue("@lastName", lastNameBox.Text);
                    cmd.Parameters.AddWithValue("@phoneNum", numBox.Text);
                    cmd.Parameters.AddWithValue("@email", emailBox.Text);
                    cmd.Parameters.AddWithValue("@unit", Convert.ToInt32(unitBox.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Adding tenant success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Adding tenant failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding tenant failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
        }
    }
}
