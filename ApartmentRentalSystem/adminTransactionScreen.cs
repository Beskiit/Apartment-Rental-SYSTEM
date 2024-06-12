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



        private void adminTransactionScreen_Load(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT transactionDate FROM [Transaction]", Connection.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DateTime transacDate = reader.GetDateTime(0);
                string status = DateTime.Now <= transacDate ? "Pending" : "Overdue";

                SqlCommand updateCmd = new SqlCommand("UPDATE [Transaction] SET status = @status WHERE transactionDate = @transactionDate", Connection.conn);
                updateCmd.Parameters.AddWithValue("@status", status);
                updateCmd.Parameters.AddWithValue("@transactionDate", transacDate);
                updateCmd.ExecuteNonQuery();
            }
            reader.Close();
            SqlCommand cmd3 = new SqlCommand("SELECT totalPrice FROM [Transaction]", Connection.conn);
            reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                decimal price = reader.GetDecimal(0);
                if (price <= 0)
                {
                    SqlCommand updateCmd = new SqlCommand("UPDATE [Transaction] SET status = @status WHERE totalPrice = @price", Connection.conn);
                    updateCmd.Parameters.AddWithValue("@status", "Paid");
                    updateCmd.Parameters.AddWithValue("@price", price);
                    updateCmd.ExecuteNonQuery();
                }
            }
            reader.Close();
            SqlCommand cmd2 = new SqlCommand("SELECT transactionID AS 'Transaction ID', tenantID AS 'Tenant ID', roomID AS 'Room ID', totalPrice AS 'Amount', transactionDate AS 'Transaction Date', status AS 'Status' FROM [Transaction]", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT transactionID AS 'Transaction ID', tenantID AS 'Tenant ID', roomID AS 'Room ID', totalPrice AS 'Amount', transactionDate AS 'Transaction Date', status AS 'Status' FROM [Transaction] WHERE CONCAT(transactionID, tenantID, roomID, totalPrice, transactionDate, status) LIKE @search", Connection.conn);
            cmd.Parameters.AddWithValue("@search", "%" +guna2TextBox1.Text+"%");
            cmd.ExecuteNonQuery();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();
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
