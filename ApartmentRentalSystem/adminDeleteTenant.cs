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

        public class Connection
        {
            //pacomment
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                adminTenantScreen tenant = new adminTenantScreen();
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Tenant WHERE tenantID = @tenantID", Connection.conn);
                cmd.Parameters.AddWithValue("@tenantID", int.Parse(tenantIdBox.Text));
                cmd.ExecuteNonQuery();
                tenant.displayTenant();
                MessageBox.Show("Delete Tenant Success.", "Success",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Tenant Failed.", "Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
        }

            private void tenantIdBox_TextChanged(object sender, EventArgs e)
        {
            adminUpdateTenant tenantUpd = new adminUpdateTenant();
            tenantUpd.displayTenant();
        }
    }
}
