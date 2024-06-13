using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            CustomizeCloseButton();

        }
        private void CustomizeCloseButton()
        {
            closeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(0xE0, 0xD2, 0xBA);
            closeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0xE0, 0xD2, 0xBA); 
            closeButton.BackColor = Color.FromArgb(0xE0, 0xD2, 0xBA); 
            closeButton.BackgroundImageLayout = ImageLayout.Stretch;
            closeButton.Cursor = Cursors.Hand; 
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

        public class Connection
        {
            public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jack_\source\repos\Apartment-Rental-SYSTEM\ApartmentRentalSystem\Database1.mdf;Integrated Security=True");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Connection.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT username, password FROM Admin", Connection.conn);
            SqlDataReader read = cmd.ExecuteReader();
            bool isLogin = false;
            while (read.Read())
            {
                if (userInput.Text == read.GetValue(0).ToString() && passwordInput.Text == read.GetValue(1).ToString())
                {
                    isLogin = true;
                    Connection.conn.Close();
                    break;
                }
                else
                {
                    isLogin = false;
                }
            }
            if (isLogin)
            {
                admin dashboard = new admin();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password. \n Please try again.", "ALERT", MessageBoxButtons.OK);
                Connection.conn.Close();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
