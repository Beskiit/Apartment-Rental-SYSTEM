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
    public partial class adminAddUser : UserControl
    {
        public adminAddUser()
        {
            InitializeComponent();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (role.Text.ToLower() == "admin")
                {
                    Connection.conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Admin (username, password, firstName, lastName) VALUES (@username, @password, @firstName, @lastName)", Connection.conn);
                    cmd.Parameters.AddWithValue("@username", usernameBox.Text);
                    cmd.Parameters.AddWithValue("@password", paswordBox.Text);
                    cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
                    cmd.Parameters.AddWithValue("@lastName", lastNameBox.Text);
                    if (MessageBox.Show("Are you sure you want add?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        cmd.Parameters.AddWithValue("@username", usernameBox.Text);
                        cmd.Parameters.AddWithValue("@password", paswordBox.Text);
                        cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
                        cmd.Parameters.AddWithValue("@lastName", lastNameBox.Text);
                        Connection.conn.Close();
                        MessageBox.Show("Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("You pressed Cancel!");
                        Connection.conn.Close();
                    }

                }
                else if (role.Text.ToLower() == "clerk")
                {
                    Connection.conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Clerk (username, password, firstName, lastName) VALUES (@username, @password, @firstName, @lastName)", Connection.conn);
                    if (MessageBox.Show("Are you sure you want add?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        cmd.Parameters.AddWithValue("@username", usernameBox.Text);
                        cmd.Parameters.AddWithValue("@password", paswordBox.Text);
                        cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
                        cmd.Parameters.AddWithValue("@lastName", lastNameBox.Text);
                        cmd.ExecuteNonQuery();
                        Connection.conn.Close();
                        MessageBox.Show("Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("You pressed Cancel!");
                        Connection.conn.Close();
                    }
                }
                else
            {
                MessageBox.Show("Incorrect role.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Connection.conn.Close();
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Adding user failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
        }

        private void adminAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
