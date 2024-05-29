using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class adminGrids : UserControl
    {
        public adminGrids()
        {
            InitializeComponent();
            
            
        }

        public string methodName(string roomName, string description, string price) 
        { 
            unitLabel.Text = Convert.ToString(roomName);
            descLabel.Text = Convert.ToString(description);
            priceLabel.Text = Convert.ToString(price);


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
