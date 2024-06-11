﻿using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ApartmentRentalSystem
{
    public partial class adminTenantScreen : UserControl
    {

        public adminTenantScreen()
        {
            InitializeComponent();

        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void adminTenantScreen_Load(object sender, EventArgs e)
        {
            displayTenant();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            displayTenant();
        }

        private void addToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            adminAddTenant add = new adminAddTenant();
            addUserControl(add);
        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            adminUpdateTenant update = new adminUpdateTenant();
            addUserControl(update);
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            adminDeleteTenant delete = new adminDeleteTenant();
            addUserControl(delete);
        }

        public void displayTenant()
        {
            SqlCommand cmd = new SqlCommand("SELECT tenantID AS 'Tenant ID', firstName AS 'First Name', lastName AS 'Last Name', roomID as 'Room ID', email AS 'Email', phoneNumber AS 'Phone Number', moveInDate AS 'Move In Date', status AS 'Status' FROM Tenant", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            guna2DataGridView2.DataSource = dt;
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
