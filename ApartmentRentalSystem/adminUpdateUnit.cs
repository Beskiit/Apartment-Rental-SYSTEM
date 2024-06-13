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
    public partial class adminUpdateUnit : UserControl
    {
        public adminUpdateUnit()
        {
            InitializeComponent();
        }

        public class Connection {
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");

        }


        private void displayUnit()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
            if (string.IsNullOrWhiteSpace(roomIdBox.Text))
            {
                roomNumBox.Text = "";
                descriptionBox.Text = "";
                amountBox.Text = "";
                return;
            }
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomNumber, description, roomPrice FROM Room WHERE roomID = @roomID", conn);
            cmd.Parameters.AddWithValue("@roomID", int.Parse(roomIdBox.Text));

            SqlDataReader read = cmd.ExecuteReader();

            roomNumBox.Text = "";
            descriptionBox.Text = "";
            amountBox.Text = "";

            while(read.Read())
            {
                roomNumBox.Text = read.GetValue(0).ToString();
                descriptionBox.Text = read.GetValue(1).ToString();
                amountBox.Text = read.GetValue(2).ToString();
            }
            read.Close();
            conn.Close();
        }

        private void updateUnit()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE Room SET roomNumber = @roomNumber, description = @description, amount = @amount WHERE roomID = @roomID", conn);
            cmd.Parameters.AddWithValue("@roomID", int.Parse(roomIdBox.Text));
            cmd.Parameters.AddWithValue("@roomNumber", int.Parse(roomNumBox.Text));
            cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
            cmd.Parameters.AddWithValue("@amount", double.Parse(amountBox.Text));
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                adminUnitScreen unit = new adminUnitScreen();
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
                conn.Open();
                updateUnit();
                MessageBox.Show("Unit updated successfully.", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                unit.displayUnit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Unit Failed.", "Failed",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Connection.conn.Close();
            }
            
        }

        private void roomIdBox_TextChanged(object sender, EventArgs e)
        {
            displayUnit();
        }
    }
}
