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
            SqlCommand cmd = new SqlCommand("INSERT INTO ");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
  
              

        }
    }
}
