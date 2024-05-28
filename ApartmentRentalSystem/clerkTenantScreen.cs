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
    public partial class clerkTenantScreen : UserControl
    {
        public clerkTenantScreen()
        {
            InitializeComponent();
        }

        private void addTenants_Click(object sender, EventArgs e)
        {
            clerkAddTenantForm clerkAddTenantForm = new clerkAddTenantForm();
            clerkAddTenantForm.Show();
        }
    }
}
