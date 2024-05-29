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
    public partial class adminAddTenantForm : Form
    {
        public adminAddTenantForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            int unit = Convert.ToInt32(unitBox.Text);
            SqlCommand cmd = new SqlCommand("INSERT INTO Tenant VALUES (@firstName, @lastName, @email, @phoneNum,@unit , @moveInDate)", Connection.conn);
            cmd.Parameters.AddWithValue("@firstName", firstNameBox.Text);
            cmd.Parameters.AddWithValue("@lastName", lastNameBox.Text);
            cmd.Parameters.AddWithValue("@email", emailBox.Text);
            cmd.Parameters.AddWithValue("@phoneNum", phoneBox.Text);
            cmd.Parameters.AddWithValue("@unit", unit);
            cmd.Parameters.AddWithValue("@moveInDate", moveInDateBox.Text);
            cmd.ExecuteNonQuery();  
            Connection.conn.Close();
        }
    }
}
