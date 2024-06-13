using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class adminAddPayment : UserControl
    {
        public adminAddPayment()
        {
            InitializeComponent();
        }

        public class Connection
        {
            //pacomment
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
        }

        private void addPayment()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
        conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Payment (transactionID, tenantID, paymentAmount, paymentDate) VALUES (@transactionID, @tenantID, @paymentAmount, @paymentDate)", conn);
            cmd.Parameters.AddWithValue("@tenantID", int.Parse(tenantIdBox.Text));
            cmd.Parameters.AddWithValue("@transactionID", int.Parse(transactionIdBox.Text));
            cmd.Parameters.AddWithValue("@paymentAmount", decimal.Parse(amountBox.Text));
            SqlCommand cmd2 = new SqlCommand("UPDATE [Transaction] SET totalPrice = totalPrice - @paymentAmount WHERE transactionID = @transactionID", conn);
            cmd2.Parameters.AddWithValue("@paymentAmount", decimal.Parse(amountBox.Text));
            cmd2.Parameters.AddWithValue("@transactionID", int.Parse(transactionIdBox.Text));
            cmd.Parameters.AddWithValue("@paymentDate", DateTime.Now);
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            Connection.conn.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                addPayment();
                MessageBox.Show("Add Payment Success.", "Success",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Adding Payment failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                Connection.conn.Close();
            }

              
            
            
        }
    }
    }
     