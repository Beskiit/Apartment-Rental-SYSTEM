using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ApartmentRentalSystem
{
    public partial class adminPaymentScreen : UserControl
    {
        public adminPaymentScreen()
        {
            InitializeComponent();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin bigForm = Application.OpenForms.OfType<admin>().FirstOrDefault();
            if (bigForm != null)
            {
                bigForm.ShowOverlay();
            }
        }

        public class CustomToolStripRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                base.OnRenderItemText(e);

                if (e.Item.Selected)
                {
                    // Increase font size when hovered
                    Font originalFont = e.Item.Font;
                    Font hoverFont = new Font(originalFont.FontFamily, originalFont.Size + 2, originalFont.Style);
                    e.TextFont = hoverFont;
                }
                else
                {
                    // Reset font size when not hovered
                    e.TextFont = e.Item.Font;
                }
            }
        }
    }
}
