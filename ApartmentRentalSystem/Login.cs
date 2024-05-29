using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.SetRoundedShape();
            SetRoundedShape();

        }

        private void SetRoundedShape()
        {
            GraphicsPath path = new GraphicsPath();
            int arcSize = 40;
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);

            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, arcSize, arcSize, 180, 90);
            path.AddArc(bounds.Right - arcSize, bounds.Y, arcSize, arcSize, 270, 90);
            path.AddArc(bounds.Right - arcSize, bounds.Bottom - arcSize, arcSize, arcSize, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - arcSize, arcSize, arcSize, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }


           
        private void loginButton_Click_1(object sender, EventArgs e)
        {
            string username1 = username.Text;
            string password1 = password.Text;

            if (username1 == "admin" && password1 == "admin123")
            {
                admin adminForm = new admin();
                adminForm.Show();
                this.Hide();
            }
            else if (username1 == "clerk" && password1 == "clerk123")
            {
                clerk clerkForm = new clerk();
                clerkForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

