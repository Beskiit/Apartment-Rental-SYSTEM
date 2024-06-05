using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class adminPaymentScreen : UserControl
    {
        public adminPaymentScreen()
        {
            InitializeComponent();


        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminAddPayment adminAddPayment = new adminAddPayment();
            addUserControl(adminAddPayment);

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminUpdatePayment adminUpdatePayment = new adminUpdatePayment();
            addUserControl (adminUpdatePayment);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           adminDeletePayment adminDeletePayment = new adminDeletePayment();
            addUserControl(adminDeletePayment);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT paymentID AS 'Payment ID', transactionID AS 'Transaction ID', amount AS 'Amount' FROM Payment", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            Connection.conn.Close();
        }

        private void adminPaymentScreen_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT paymentID AS 'Payment ID', tenantID AS 'Tenant ID', amount AS 'Amount' FROM Payment", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            Connection.conn.Close();
        }
    }
}
