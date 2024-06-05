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
    public partial class clerkPaymentScreen : UserControl
    {
        public clerkPaymentScreen()
        {
            InitializeComponent();
        }

        private void clerkPaymentScreen_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT paymentID AS 'Payment ID', transactionID AS 'Transaction ID', amount AS 'Amount' FROM Payment", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            Connection.conn.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addPayment_Click(object sender, EventArgs e)
        {
        }

        private void clerkAddPayment11_Load(object sender, EventArgs e)
        {

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
            clerkAddPayment cap = new clerkAddPayment();
            addUserControl(cap);
            

        }

        private void updateTenantClerk_Click(object sender, EventArgs e)
        {
            clerkUpdatePayment cup = new clerkUpdatePayment();
            addUserControl (cup);

       
        }

        private void updatePaymentClerk_Click(object sender, EventArgs e)
        {
            clerkUpdatePayment cup = new clerkUpdatePayment();
            addUserControl(cup);
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
    }
}
