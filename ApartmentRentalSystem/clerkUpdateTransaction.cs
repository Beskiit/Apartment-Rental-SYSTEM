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
    public partial class clerkUpdateTransaction : UserControl
    {
        public clerkUpdateTransaction()
        {
            InitializeComponent();
        }

        private void clerkUpdateTransaction_Load(object sender, EventArgs e)
        {

        }

        private void updatePaymentClerk_Click(object sender, EventArgs e)
        {

        }

        private void updatePaymentClerk_Click_1(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Transaction SET amount = @amount, tenantID = @tenantID, unitID = @unitID WHERE transactionID = @transactionID", Connection.conn);
                if (MessageBox.Show("Are you sure you want update?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    cmd.Parameters.AddWithValue("@transactionID", Convert.ToInt32(transactionIdBox.Text));
                    cmd.Parameters.AddWithValue("@tenantID", Convert.ToInt32(tenantIdBox.Text));
                    cmd.Parameters.AddWithValue("@unitID", Convert.ToInt32(unitIdBox.Text));
                    cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(amountBox.Text));
                    MessageBox.Show("Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("You pressed Cancel!");
                    Connection.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updating transaction failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
        }
    }
}
