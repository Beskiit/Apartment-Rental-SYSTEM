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
    public partial class updateTenant : UserControl
    {
        public updateTenant()
        {
            InitializeComponent();
        }
                private void guna2Button1_Click(object sender, EventArgs e)
                {
                    if (MessageBox.Show("Are you sure you want update?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MessageBox.Show("Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("You pressed Cancel!");
                    }
            /*
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Tenant SET firstName = @firstName, lastName = @lastName, email = @email, phoneNum = @phoneNum, unit = @unit WHERE tenantID = @tenantID", Connection.conn);
            cmd.Parameters.AddWithValue("@tenantID", Convert.ToInt32(tenantIdBox.Text));
            cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
            cmd.Parameters.AddWithValue("@lastName", lastNameBox.Text);
            cmd.Parameters.AddWithValue("@phoneNum", numBox.Text);
            cmd.Parameters.AddWithValue("@email", emailBox.Text);
            cmd.Parameters.AddWithValue("@unit", Convert.ToInt32(unitBox.Text));
            cmd.ExecuteNonQuery();
            Connection.conn.Close();
            MessageBox.Show("Updating tenant success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            */
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void updateTenant_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void lastNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void unitBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
