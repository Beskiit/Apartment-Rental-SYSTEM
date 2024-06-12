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
    public partial class adminAddPayment : UserControl
    {
        public adminAddPayment()
        {
            InitializeComponent();
        }

        private void addPayment()
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Payment (transactionID, tenantID, paymentAmount, paymentDate) VALUES (@transactionID, @tenantID, @paymentAmount, @paymentDate)", Connection.conn);
            cmd.Parameters.AddWithValue("@tenantID", int.Parse(tenantIdBox.Text));
            cmd.Parameters.AddWithValue("@transactionID", int.Parse(transactionIdBox.Text));
            cmd.Parameters.AddWithValue("@paymentAmount", decimal.Parse(amountBox.Text));
            SqlCommand cmd2 = new SqlCommand("UPDATE [Transaction] SET totalPrice = totalPrice - @paymentAmount WHERE transactionID = @transactionID", Connection.conn);
            cmd2.Parameters.AddWithValue("@paymentAmount", decimal.Parse(amountBox.Text));
            cmd2.Parameters.AddWithValue("@transactionID", int.Parse(transactionIdBox.Text));
            cmd.ExecuteNonQuery();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            addPayment();
            Connection.conn.Close();
        }
    }
}
