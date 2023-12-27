using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Chuong8
{
    public partial class FrmDrawImage : Form
    {
        public FrmDrawImage()
        {
            InitializeComponent();
        }

        private void FrmDrawImage_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rct1 = new Rectangle(0, 0, ClientRectangle.Width / 2, ClientRectangle.Height/2);
            Rectangle rct2 = new Rectangle(0, ClientRectangle.Height / 2, ClientRectangle.Width / 2, ClientRectangle.Height);
            Rectangle rct3 = new Rectangle(ClientRectangle.Height / 2, ClientRectangle.Width / 2, ClientRectangle.Height, ClientRectangle.Width);
            DrawImage(rct1, e.Graphics);
            DrawText(rct2, e.Graphics);
            DrawPoly(rct3, e.Graphics) ;
        }

        private void DrawText(Rectangle rct2, Graphics graphics)
        {
           
        }

        private void DrawPoly(Rectangle rct1, Graphics graphics)
        {

        }

        private void DrawImage(Rectangle rct1, Graphics graphics)
        {
            Image img = Image.FromFile(Application.StartupPath + @"\canh2.jpg");
            graphics.DrawImage(img, rct1);
            Font f = new Font("Arial", 24, FontStyle.Bold);
            SolidBrush br = new SolidBrush(Color.FromArgb(100, 255, 255, 0));
            StringFormat fm = new StringFormat();

            fm.LineAlignment = StringAlignment.Far;
            graphics.DrawString("Anita", f, br, rct1, fm);

        }
    }
}
