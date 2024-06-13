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


        public class Connection
        {
            //pacomment
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
        }
        private void adminTransactionScreen_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
            List<Tuple<DateTime, decimal>> transactions = new List<Tuple<DateTime, decimal>>();
            string selectQuery = "SELECT transactionDate, totalPrice FROM [Transaction]";
            using (SqlCommand selectCmd = new SqlCommand(selectQuery, Connection.conn))
            using (SqlDataReader reader = selectCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DateTime transacDate = reader.GetDateTime(0);
                    decimal totalPrice = reader.GetDecimal(1);
                    transactions.Add(new Tuple<DateTime, decimal>(transacDate, totalPrice));
                }
            }

            foreach (var transaction in transactions)
            {
                DateTime transacDate = transaction.Item1;
                decimal totalPrice = transaction.Item2;

                string status = DateTime.Now <= transacDate ? "Pending" : "Overdue";

                using (SqlCommand updateCmd = new SqlCommand("UPDATE [Transaction] SET status = @status WHERE transactionDate = @transactionDate", Connection.conn))
                {
                    updateCmd.Parameters.AddWithValue("@status", status);
                    updateCmd.Parameters.AddWithValue("@transactionDate", transacDate);
                    updateCmd.ExecuteNonQuery();
                }

                if (totalPrice <= 0)
                {
                    using (SqlCommand updateCmd = new SqlCommand("UPDATE [Transaction] SET status = @status WHERE totalPrice = @totalPrice", Connection.conn))
                    {
                        updateCmd.Parameters.AddWithValue("@status", "Paid");
                        updateCmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                        updateCmd.ExecuteNonQuery();
                    }
                }
            }


            using (SqlCommand cmd2 = new SqlCommand("SELECT transactionID AS 'Transaction ID', tenantID AS 'Tenant ID', roomID AS 'Room ID', totalPrice AS 'Amount', transactionDate AS 'Transaction Date', status AS 'Status' FROM [Transaction]", Connection.conn))
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd2))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                guna2DataGridView2.DataSource = dt;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT transactionID AS 'Transaction ID', tenantID AS 'Tenant ID', roomID AS 'Room ID', totalPrice AS 'Amount', transactionDate AS 'Transaction Date', status AS 'Status' FROM [Transaction] WHERE CONCAT(transactionID, tenantID, roomID, totalPrice, transactionDate, status) LIKE @search", Connection.conn);
            cmd.Parameters.AddWithValue("@search", "%" + guna2TextBox1.Text + "%");
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            guna2DataGridView2.DataSource = dt;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT transactionID AS 'Transaction ID', tenantID AS 'Tenant ID', roomID AS 'Room ID', totalPrice AS 'Amount', transactionDate AS 'Transaction Date', status AS 'Status' FROM [Transaction]", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }
    }
}

