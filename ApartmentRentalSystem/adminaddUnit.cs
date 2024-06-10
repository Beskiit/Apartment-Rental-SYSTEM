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
    public partial class adminaddUnit : UserControl
    {
        public adminaddUnit()
        {
            InitializeComponent();
        }

        private void addUnit()
        {
            Login login = new Login();
            SqlCommand cmd = new SqlCommand("SELECT adminID FROM Admin WHERE username = @username", Connection.conn);
            cmd.Parameters.AddWithValue("@username", login.userInput.Text);
            SqlDataReader read = cmd.ExecuteReader();
            int adminID = read.GetInt32(0);
            cmd = new SqlCommand("INSERT INTO Room adminID, description, roomPrice, roomNumber, status VALUES (@adminID, @description, @roomPRice, @roomNumber, @status)", Connection.conn);
            cmd.Parameters.AddWithValue("@adminID", adminID);
            cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
            cmd.Parameters.AddWithValue("@roomPrice", amountBox.Text);
            cmd.Parameters.AddWithValue("@status", "Vacant");
            cmd.ExecuteNonQuery();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            addUnit();
        }

        private void roomNumberBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
