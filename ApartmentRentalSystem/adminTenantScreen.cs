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
    public partial class adminTenantScreen : UserControl
    {
        static SqlCommand cmd = new SqlCommand();
        public adminTenantScreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminAddTenantForm adminAddTenantForm = new adminAddTenantForm();
            adminAddTenantForm.Show();
        }

        private void adminTenantScreen_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
            cmd = new SqlCommand("SELECT firstName, lastName, phoneNumber, unit, moveInDate FROM Tenant", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            dataGridTenantScreen.DataSource = dataTable;
        }
    }
}
