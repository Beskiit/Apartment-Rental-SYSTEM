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

        public class Connection
        {
            //pacomment
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                adminUnitScreen unit = new adminUnitScreen();
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Room WHERE roomID = @roomID", Connection.conn);
                cmd.Parameters.AddWithValue("@roomID", int.Parse(roomIdBox.Text));
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                unit.displayUnit();
                MessageBox.Show("Deleted Unit Success.", "Success",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Unit Failed.", "Failed",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Connection.conn.Close();
            }
                
                
        }
    }
}
