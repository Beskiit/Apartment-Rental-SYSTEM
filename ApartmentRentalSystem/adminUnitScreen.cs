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
    public partial class adminUnitScreen : UserControl
    {
        public adminUnitScreen()
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
        private void adminUnitScreen_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomID AS 'Room ID', roomNumber AS 'Room Number', description AS 'Description', status AS 'Status' FROM Room", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT roomID AS 'Room ID', roomNumber AS 'Room Number', description AS 'Description', status AS 'Status' FROM Room", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            adminaddUnit adminaddUnit = new adminaddUnit();
            addUserControl(adminaddUnit);
        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            adminUpdateUnit adminUpdateUnit = new adminUpdateUnit();
            addUserControl(adminUpdateUnit);
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            adminDeleteUnit adminDeleteUnit = new adminDeleteUnit();
            addUserControl(adminDeleteUnit);
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
