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
    public partial class adminTransactionScreen : UserControl
    {
        public adminTransactionScreen()
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminAddTransaction adminAddTransaction = new adminAddTransaction();
            addUserControl(adminAddTransaction);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminUpdateTransaction admin = new adminUpdateTransaction();
            addUserControl (admin);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminDeleteTransaction adminDeleteTransaction = new adminDeleteTransaction();
            addUserControl(adminDeleteTransaction);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT transactionID AS 'Transaction ID', tenantID AS 'Tenant ID', roomID AS 'Room ID', totalCost AS 'Amount' FROM Transaction", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }

        private void adminTransactionScreen_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT transactionID AS 'Transaction ID', tenantID AS 'Tenant ID', roomID AS 'Room ID', totalCost AS 'Amount' FROM Transaction", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }
    }
}
