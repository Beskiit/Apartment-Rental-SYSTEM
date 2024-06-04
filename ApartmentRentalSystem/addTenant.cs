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
    public partial class addTenant : UserControl
    {
        public addTenant()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tenant (firstName, lastName, phoneNum, email, unit) VALUES (@firstName, @lastName, @phoneNum, @email, @unit)", Connection.conn);
                cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
                cmd.Parameters.AddWithValue("@lastName", lastNameBox.Text);
                cmd.Parameters.AddWithValue("@phoneNum", numBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@unit", Convert.ToInt32(unitBox.Text));
                cmd.ExecuteNonQuery();
                Connection.conn.Close();
                MessageBox.Show("Adding tenant success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*}
            catch (Exception ex)
            {
                MessageBox.Show("Adding tenant failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
