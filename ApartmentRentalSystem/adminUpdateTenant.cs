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
    public partial class adminUpdateTenant : UserControl
    {
        public adminUpdateTenant()
        {
            InitializeComponent();
        }
        private void updateTenant()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Tenant SET firstName = @firstName, lastName = @lastName, phoneNumber = @phoneNumber, email = @email, moveInDate = @moveInDate, roomNumber = @roomNumber WHERE tenantID = @tenantID");
            cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
            cmd.Parameters.AddWithValue("lastName", lastNameBox.Text);
            cmd.Parameters.AddWithValue("@email", emailBox.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", numBox.Text);
            cmd.Parameters.AddWithValue("@moveInDate", moveInBox.Value.ToString());
            cmd.Parameters.AddWithValue("@roomNumber", unitBox.Text);
            cmd.Parameters.AddWithValue("@tenantID", tenantIdBox.Text);
            cmd.ExecuteNonQuery();
        }

        public void displayTenant()
        {
            if (string.IsNullOrWhiteSpace(tenantIdBox.Text))
            {
                firstNameBox.Text = "";
                lastNameBox.Text = "";
                emailBox.Text = "";
                numBox.Text = "";
                moveInBox.Value = DateTime.Now;
                unitBox.Text = "";
                return;
            }
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT firstName, lastName, email, phoneNumber, moveInDate, roomNumber FROM Tenant WHERE tenantID = @tenantID");
            cmd.Parameters.AddWithValue("@tenantID", int.Parse(tenantIdBox.Text));
            SqlDataReader read = cmd.ExecuteReader();

            firstNameBox.Text = "";
            lastNameBox.Text = "";
            emailBox.Text = "";
            numBox.Text = "";
            moveInBox.Value = DateTime.Now;
            unitBox.Text = "";

            while (read.Read())
            {
                firstNameBox.Text = read.GetValue(0).ToString();
                lastNameBox.Text = read.GetValue(1).ToString();
                emailBox.Text = read.GetValue(2).ToString();
                numBox.Text = read.GetValue(3).ToString();
                moveInBox.Value = read.GetDateTime(4);
                unitBox.Text = read.GetValue(5).ToString();
            }

            read.Close();

            Connection.conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                adminTenantScreen tenant = new adminTenantScreen();
                Connection.conn.Open();
                updateTenant();
                tenant.displayTenant();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updating tenant failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
        }

        private void tenantIdBox_TextChanged(object sender, EventArgs e)
        {
            displayTenant();
        }
    }
}
