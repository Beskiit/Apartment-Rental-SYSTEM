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
            SqlCommand cmd = new SqlCommand("INSERT INTO Room (adminID, description, roomPrice, roomNumber, status) VALUES (@adminID, @description, @roomPRice, @roomNumber, @status)", Connection.conn);
            cmd.Parameters.AddWithValue("@adminID", 1001);
            cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
            cmd.Parameters.AddWithValue("@roomPrice", decimal.Parse(amountBox.Text));
            cmd.Parameters.AddWithValue("@roomNumber", int.Parse(roomNumberBox.Text));
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
            Connection.conn.Close();
        }

        private void roomNumberBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
