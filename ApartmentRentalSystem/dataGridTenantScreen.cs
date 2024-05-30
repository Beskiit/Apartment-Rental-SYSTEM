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
    public partial class dataGridTenantScreen : UserControl
    {
        public dataGridTenantScreen()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT firstName, lastName, phoneNumber, unit, moveInDate FROM Tenant");
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
            catch
            {

            }
        }
    }
}
