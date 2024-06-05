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
    public partial class adminUpdateTransaction : UserControl
    {
        public adminUpdateTransaction()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Transaction SET amount = @amount, tenantID = @tenantID, unitID = @unitID WHERE transactionID = @transactionID", Connection.conn);
                if (MessageBox.Show("Are you sure you want update?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    cmd.Parameters.AddWithValue("@transactionID", Convert.ToInt32(transacIdBox.Text));
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

        private void tenantIdBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
