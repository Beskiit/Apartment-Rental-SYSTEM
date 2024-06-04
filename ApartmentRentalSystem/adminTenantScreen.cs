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
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT tenantID AS 'Tenant ID', firstName AS 'First Name', lastName AS 'Last Name', email AS 'Email', phoneNum AS 'Phone Number', unit AS 'Unit' FROM Tenant", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT tenantID AS 'Tenant ID', firstName AS 'First Name', lastName AS 'Last Name', email AS 'Email', phoneNum AS 'Phone Number', unit AS 'Unit' FROM Tenant", Connection.conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            guna2DataGridView2.DataSource = dt;
            Connection.conn.Close();

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
            addUserControl (delete);
        }
            private void generateContract_Click(object sender, EventArgs e)
            {
          
            }
        }
    }
