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
    public partial class clerkUpdateUnit : UserControl
    {
        public clerkUpdateUnit()
        {
            InitializeComponent();
        }

        private void updatePaymentClerk_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Room SET roomNumber = @roomNumber, description = @description, price = @price WHERE roomID = @roomID", Connection.conn);

                if (MessageBox.Show("Are you sure you want update?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    cmd.Parameters.AddWithValue("@roomID", Convert.ToInt32(roomIdBox.Text));
                    cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
                    cmd.Parameters.AddWithValue("@roomNumber", Convert.ToInt32(roomNumBox.Text));
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(amountBox.Text));
                    cmd.ExecuteNonQuery();
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
                MessageBox.Show("Updating unit failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Connection.conn.Close();
            }
        }
    }
}
