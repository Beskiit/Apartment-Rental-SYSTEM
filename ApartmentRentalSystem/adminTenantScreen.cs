using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class adminTenantScreen : UserControl
    {
        private addTenant addTenantControl;

        public adminTenantScreen()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTenant addTenant = new addTenant();
            addUserControl(addTenant);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateTenant updateTenant = new updateTenant();
            addUserControl(updateTenant);
        }

        private void adminTenantScreen_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT tenantID AS 'Tenant ID', firstName AS 'First Name', lastName AS 'Last Name', email AS 'Email', phoneNum AS 'Phone Number', unit AS 'Unit' FROM Tenant", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteTenant deleteTenant = new deleteTenant();
            addUserControl(deleteTenant);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT tenantID, firstName, lastName, email, phoneNum, unit FROM Tenant", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }
    }
}