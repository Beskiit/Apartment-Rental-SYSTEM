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
    public partial class adminUserScreen : UserControl
    {
        public adminUserScreen()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void adminUserScreen_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT clerkID AS 'Clerk ID', username AS 'Userame', password AS 'Password', firstName AS 'First Name', lastName AS 'Last Name' FROM Clerk", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;

            cmd = new SqlCommand("SELECT adminID AS 'Admin ID', username AS 'Userame', password AS 'Password', firstName AS 'First Name', lastName AS 'Last Name' FROM Admin", Connection.conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminAddUser adminAddUser = new adminAddUser();
            addUserControl(adminAddUser);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminUpdateUnit adminUpdateUnit = new adminUpdateUnit();
            addUserControl(adminUpdateUnit);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminDeletePayment adminDeletePayment = new adminDeletePayment();
            addUserControl (adminDeletePayment);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT clerkID AS 'Clerk ID', username AS 'Userame', password AS 'Password', firstName AS 'First Name', lastName AS 'Last Name' FROM Clerk", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;

            cmd = new SqlCommand("SELECT adminID AS 'Admin ID', username AS 'Userame', password AS 'Password', firstName AS 'First Name', lastName AS 'Last Name' FROM Admin", Connection.conn);
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }
    }
}
