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

        private void displayUnit()
        {
            if (string.IsNullOrWhiteSpace(roomIdBox.Text))
            {
                roomNumBox.Text = "";
                descriptionBox.Text = "";
                amountBox.Text = "";
                return;
            }
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomNumber, description, roomPrice FROM Room WHERE roomID = @roomID", Connection.conn);
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
            Connection.conn.Close();
        }

        private void updateUnit()
        {
            SqlCommand cmd = new SqlCommand("UPDATE Room SET roomNumber = @roomNumber, description = @description, amount = @amount WHERE roomID = @roomID");
            cmd.Parameters.AddWithValue("@roomID", int.Parse(roomIdBox.Text));
            cmd.Parameters.AddWithValue("@roomNumber", int.Parse(roomNumBox.Text));
            cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
            cmd.Parameters.AddWithValue("@amount", double.Parse(amountBox.Text));
        }

        private void adminUpdateUnit_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            adminUnitScreen unit = new adminUnitScreen();
            Connection.conn.Open();
            updateUnit();
            unit.displayUnit();
        }

        private void roomIdBox_TextChanged(object sender, EventArgs e)
        {
            displayUnit();
        }
    }
}
