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

        private void checkStatus()
        {
            SqlCommand cmd = new SqlCommand("SELECT status FROM Room WHERE roomID = @roomID",Connection.conn);
            cmd.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                if (read.GetValue(0).ToString() == "Vacant")
                {
                    read.Close();
                    cmd = new SqlCommand("UPDATE Room SET status = 'Occupied'", Connection.conn);
                    cmd.ExecuteNonQuery();
                }
                else if (read.GetValue(0).ToString() == "Occupied")
                {
                    MessageBox.Show("This room is occupied! Please find another room.", "Occupied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    read.Close();
                }
                else if (read.GetValue(0).ToString() == "Not Available")
                {
                    MessageBox.Show("This room is not available! Please find another room.", "Not available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    read.Close();
                }
            }
        }

        private void addTenant()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Tenant (firstName, lastName, email, phoneNumber, moveInDate, roomID) VALUES (@firstName, @lastName, @email, @phoneNumber, @moveInDate, @roomNumber)", Connection.conn);
                cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
                cmd.Parameters.AddWithValue("@lastName", lastNameBox.Text);
                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@phoneNumber", numBox.Text);
                cmd.Parameters.AddWithValue("@moveInDate", moveInBox.Value.ToString());
                cmd.Parameters.AddWithValue("@roomNumber", int.Parse(unitBox.Text));

                cmd.ExecuteNonQuery();

                SqlCommand checkRoomCmd = new SqlCommand("SELECT status FROM Room WHERE roomID = @roomID", Connection.conn);
                checkRoomCmd.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));

                SqlDataReader read = checkRoomCmd.ExecuteReader();

                while (read.Read())
                {
                    if (read.GetValue(0).ToString() == "Vacant")
                    {
                        read.Close();

                        SqlCommand updateRoomCmd = new SqlCommand("UPDATE Room SET status = 'Occupied' WHERE roomID = @roomID", Connection.conn);
                        updateRoomCmd.Parameters.AddWithValue("@roomID", int.Parse(unitBox.Text));
                        updateRoomCmd.ExecuteNonQuery();

                        MessageBox.Show("Adding tenant success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        firstNameBox.Text = "";
                        lastNameBox.Text = "";
                        emailBox.Text = "";
                        numBox.Text = "";
                        moveInBox.Value = DateTime.Now;
                        unitBox.Text = "";

                        return;
                    }
                    else if (read.GetValue(0).ToString() == "Occupied")
                    {
                        MessageBox.Show("This room is occupied! Please find another room.", "Occupied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        read.Close();
                        return;
                    }
                    else if (read.GetValue(0).ToString() == "Not Available")
                    {
                        MessageBox.Show("This room is not available! Please find another room.", "Not available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        read.Close();
                        return;
                    }
                }

                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding tenant: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                adminTenantScreen tenant = new adminTenantScreen(); 
                Connection.conn.Open();
                addTenant();
                tenant.displayTenant();
                Connection.conn.Close();
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
