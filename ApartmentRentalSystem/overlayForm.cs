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
    public partial class overlayForm : Form
    {
        public overlayForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.Opacity = 0.5; 
            this.StartPosition = FormStartPosition.Manual;
            this.ShowInTaskbar = false;
            this.TopMost = true; 
        }
        public void SetOwner(Form owner)
        {
            this.Owner = owner;
            this.Location = owner.Location;
            this.Size = owner.Size;
            owner.LocationChanged += (s, e) => this.Location = owner.Location;
            owner.SizeChanged += (s, e) => this.Size = owner.Size;
        }
    }
}
    
