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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Payment (tenantID, amount) VALUES (@tenantID, @amount)");
                cmd = new SqlCommand("UPDATE Transaction SET totalCost -= @amount");
                if (MessageBox.Show("Are you sure you want add?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    cmd.Parameters.AddWithValue("@tenantID", Convert.ToInt32(tenantIdBox.Text));
                    cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(amountBox.Text));
                    cmd.Parameters.Add("@amount", Convert.ToDecimal(amountBox.Text));
                    cmd.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!");
                }
                else
                {
                    MessageBox.Show("You pressed Cancel!");
                    Connection.conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adding payment failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }

        }
    }
}
