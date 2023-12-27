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
    public partial class FrmDrawText : Form
    {
        public FrmDrawText()
        {
            InitializeComponent();
        }

        private void FrmDrawText_Paint(object sender, PaintEventArgs e)
        {
            Font f = new Font("Arial", 36, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("HELLO", f, Brushes.Green, ClientRectangle,format);

            TextureBrush tbr = new TextureBrush(Image.FromFile(Application.StartupPath + @"\canh1.jpg"));
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString("HELLO", f, tbr, ClientRectangle,format);

            HatchBrush hbr = new HatchBrush(HatchStyle.Cross, Color.Red, Color.Yellow);
            format.FormatFlags = StringFormatFlags.DirectionVertical;
            format.LineAlignment = StringAlignment.Near;
            e.Graphics.DrawString("HELLO", f, hbr, ClientRectangle, format);

            LinearGradientBrush lbr = new LinearGradientBrush(new Rectangle(0, 0, 10, 10), Color.White, Color.Blue,45);
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Far;
            format.FormatFlags = StringFormatFlags.DirectionVertical;
            e.Graphics.DrawString("HELLO", f, lbr, ClientRectangle, format);
        }
    }
}
