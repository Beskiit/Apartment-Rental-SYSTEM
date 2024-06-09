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
    public partial class adminAddTenant : UserControl
    {
        public adminAddTenant()
        {
            InitializeComponent();
        }

        private void addTenant()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Tenant (firstName, lastName, email, phoneNumber, moveInDate, roomNumber) VALUES @firstName, @lastName, @email, @phoneNumber, @moveInDate, @roomNumber", Connection.conn);
            cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
            cmd.Parameters.AddWithValue("lastName", lastNameBox.Text);
            cmd.Parameters.AddWithValue("@email", emailBox.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", numBox.Text);
            cmd.Parameters.AddWithValue("@moveInDate", moveInBox.Value.ToString());
            cmd.Parameters.AddWithValue("@roomNumber", unitBox.Text);
            cmd.ExecuteNonQuery();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
               Connection.conn.Open();
               addTenant();
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

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
