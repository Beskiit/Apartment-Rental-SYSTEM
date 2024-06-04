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
    public partial class adminDeleteUser : UserControl
    {
        public adminDeleteUser()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (role.Text.ToLower() == "admin")
                {
                    SqlCommand cmd = new SqlCommand("DELETE Admin WHERE adminID = @adminID)", Connection.conn);
                    cmd.Parameters.AddWithValue("@adminID", ID.Text);
                    if (MessageBox.Show("Are you sure you want delete?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        cmd.Parameters.AddWithValue("@adminID", ID.Text);
                        cmd.ExecuteNonQuery();
                        Connection.conn.Close();
                        MessageBox.Show("User Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("You pressed Cancel!");
                    }

                }
                else if (role.Text.ToLower() == "clerk")
                {
                    SqlCommand cmd = new SqlCommand("DELETE Clerk WHERE clerkID = @clerkID)", Connection.conn);
                    cmd.Parameters.AddWithValue("@clerkID", ID.Text);
                    if (MessageBox.Show("Are you sure you want delete?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        cmd.Parameters.AddWithValue("@clerkID", ID.Text);
                        cmd.ExecuteNonQuery();
                        Connection.conn.Close();
                        MessageBox.Show("User Deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("You pressed Cancel!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User delete failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
        }

        private void adminDeleteUser_Load(object sender, EventArgs e)
        {

        }
    }
}
