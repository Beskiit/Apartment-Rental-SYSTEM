﻿using System;
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
    public partial class adminDeleteUnit : UserControl
    {
        public adminDeleteUnit()
        {
            InitializeComponent();
        }

        private void adminDeleteUnit_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("ALTER TABLE Room DROP COLUMN roomID WHERE roomID = @roomID", Connection.conn);
            cmd.Parameters.AddWithValue("@roomID", int.Parse(roomIdBox.Text));
            cmd.ExecuteNonQuery();
            Connection.conn.Close();
        }
    }
}
