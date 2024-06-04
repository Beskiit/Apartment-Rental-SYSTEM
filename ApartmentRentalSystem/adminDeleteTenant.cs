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
    public partial class deleteTenant : UserControl
    {
        public deleteTenant()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE Tenant WHERE tenantID = @tenantID", Connection.conn);
            cmd.Parameters.AddWithValue("@tenantID", Convert.ToInt32(tenantIdBox.Text));
            cmd.ExecuteNonQuery();
            Connection.conn.Close();
            MessageBox.Show("Tenant successfuly deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteTenant_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void numBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void unitBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
