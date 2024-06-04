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
    public partial class adminUpdateTenant : UserControl
    {
        public adminUpdateTenant()
        {
            InitializeComponent();
        }

        private void adminUpdateTenant_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
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
    }
}
