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
    public partial class adminUnitScreen : UserControl
    {
        public adminUnitScreen()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminAddUnitForm adminAddUnitForm = new adminAddUnitForm();
            adminAddUnitForm.Show();
        }

        private void adminUnitScreen_Load(object sender, EventArgs e)
        {

        }

        private void dataGridUnitScreen1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
