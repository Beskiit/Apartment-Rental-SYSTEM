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
    public partial class clerkUnitScreen : UserControl
    {
        public clerkUnitScreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Updated Successfully!");
            }
            else
            {
                MessageBox.Show("You pressed Cancel!");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateClerkUnit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want update?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Updated Successfully!");
            }
            else
            {
                MessageBox.Show("You pressed Cancel!");
            }
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();


        }
        private void addPaymentClerk_Click(object sender, EventArgs e)
        {
            clerkAddUnit cau = new clerkAddUnit();
            addUserControl(cau);
        }

        private void updatePaymentClerk_Click(object sender, EventArgs e)
        {
            clerkUpdateUnit cuu = new clerkUpdateUnit();
            addUserControl(cuu);
        }

        private void clerkUnitScreen_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomID AS 'Room ID', roomNumber AS 'Room Number', description AS 'Description', price AS 'Price', status AS 'Status' FROM Room", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            Connection.conn.Close();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomID AS 'Room ID', roomNumber AS 'Room Number', description AS 'Description', price AS 'Price', status AS 'Status' FROM Room", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            Connection.conn.Close();
        }
    }
}
