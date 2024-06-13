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
    public partial class adminLeaseScreen : UserControl
    {
        public adminLeaseScreen()
        {
            InitializeComponent();
        }

        public class Connection
        {
            //pacomment
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
        }

        private void adminLeaseScreen_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT formID AS 'Form ID', tenantID AS 'Tenant ID', roomID AS 'Room ID', fileName AS 'File Name', startOfContract AS 'Start of Contract', endOfContract AS 'End of Contract' FROM [Agreement_Form]", Connection.conn);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                guna2DataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Failed", MessageBoxButtons.OK);
            }
            Connection.conn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT formID AS 'Form ID', tenantID AS 'Tenant ID', roomID AS 'Room ID', fileName AS 'File Name', startOfContract AS 'Start of Contract', endOfContract AS 'End of Contract' FROM [Agreement_Form]", Connection.conn);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                guna2DataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Failed", MessageBoxButtons.OK);
            }
            finally
            {
                Connection.conn.Close();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT formID AS 'Form ID', tenantID AS 'Tenant ID', roomID AS 'Room ID', fileName AS 'File Name', startOfContract AS 'Start of Contract', endOfContract AS 'End of Contract' FROM [Agreement_Form] WHERE CONCAT(formID, tenantID, roomID, fileName, startOfContract, endOfContract) LIKE @search", Connection.conn);
            cmd.Parameters.AddWithValue("@search", "%" + guna2TextBox1.Text + "%");
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }
    }
}
