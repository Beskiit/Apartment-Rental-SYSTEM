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
            adminAddPayment adminAddPayment = new adminAddPayment();
            addUserControl(adminAddPayment);
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT paymentID AS 'Payment ID', transactionID AS 'Transaction ID', tenantID AS 'Tenant ID', paymentAmount AS 'Amount', paymentDate AS 'Payment Date' FROM Payment WHERE CONCAT(paymentID, transactionID, tenantID, paymentAmount, paymentDate) LIKE @search", conn);
            cmd.Parameters.AddWithValue("@search", guna2TextBox1.Text);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            guna2DataGridView1.DataSource = dt;
            conn.Close();
        }

        private void adminPaymentScreen_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT paymentID AS 'Payment ID', transactionID AS 'Transaction ID', tenantID AS 'Tenant ID', paymentAmount AS 'Amount', paymentDate AS 'Payment Date' FROM Payment", conn);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            guna2DataGridView1.DataSource = dt;
            conn.Close();
        }

        public class Connection
        {
            //pacomment
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT paymentID AS 'Payment ID', transactionID AS 'Transaction ID', tenantID AS 'Tenant ID', paymentAmount AS 'Amount', paymentDate AS 'Payment Date' FROM Payment", Connection.conn);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            guna2DataGridView1.DataSource = dt;
            Connection.conn.Close();
        }
    }
}
