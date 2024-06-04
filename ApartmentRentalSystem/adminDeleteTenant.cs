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
    public partial class adminDeleteTenant : UserControl
    {
        public adminDeleteTenant()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE Tenant WHERE tenantID = @tenantID", Connection.conn);
                cmd.Parameters.AddWithValue("@tenantID", Convert.ToInt32(tenantIdBox.Text));
                cmd.ExecuteNonQuery();
                Connection.conn.Close();
                MessageBox.Show("Tenant successfuly deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tenant delete failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
        }
    }
}
