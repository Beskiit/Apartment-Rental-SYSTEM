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
            adminTenantScreen tenant = new adminTenantScreen();
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("ALTER TABLE Tenant DROP COLUMN tenantID where tenantID = @tenantID", Connection.conn);
            cmd.Parameters.AddWithValue("@tenantID", int.Parse(tenantIdBox.Text));
            cmd.ExecuteNonQuery();
            tenant.displayTenant();
            Connection.conn.Close();
        }

        private void tenantIdBox_TextChanged(object sender, EventArgs e)
        {
            adminUpdateTenant tenantUpd = new adminUpdateTenant();
            tenantUpd.displayTenant();
        }
    }
}
