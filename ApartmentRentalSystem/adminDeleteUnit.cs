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
    public partial class adminDeleteUnit : UserControl
    {
        public adminDeleteUnit()
        {
            InitializeComponent();
        }

        private void adminDeleteUnit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE Tenant WHERE roomID = @roomID", Connection.conn);
                if (MessageBox.Show("Are you sure you want delete?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    cmd.Parameters.AddWithValue("@roomID", Convert.ToInt32(roomIdBox));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully!");
                }
                else
                {
                    MessageBox.Show("You pressed Cancel!");
                    Connection.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updating unit failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
        }
    }
}
