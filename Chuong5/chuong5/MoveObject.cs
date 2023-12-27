using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace chuong5
{

    public partial class MoveObject : Form
    {
        Random rand = new Random();
        string[] arrFile;
        string pathPic;
        Point pOld;
        int count = 0;
        public MoveObject()
        {
            InitializeComponent();
        }

        private void MoveObject_Load(object sender, EventArgs e)
        {
            pathPic = Application.StartupPath + @"\Pic\";
            arrFile = Directory.GetFiles(pathPic);
            AddNewPic();
        }
        void AddNewPic()
        {
            count++;
            int index = rand.Next(arrFile.Length);
            Image img = Image.FromFile(arrFile[index]);
            PictureBox pic = new PictureBox();
            pic.Name = count.ToString();
            pic.Image = img;
            pic.Location = new Point(0, 0);
            pic.Width = 90;
            pic.Height = 90;
            pic.MouseDown += Pic_MouseDown;
            pic.MouseUp += Pic_MouseUp;
            pic.MouseMove += Pic_MouseMove;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pic);
            this.Controls.SetChildIndex(pnBounds, this.Controls.Count - 1);
             
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - pOld.X;
                int dy = e.Y - pOld.Y;
                pic.Left += dx;
                pic.Top += dy;
            }
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pnBounds.Bounds.Contains(pic.Bounds))
            {
                pnBounds.Controls.Add(pic);
                AddNewPic();
            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;

        }

        private void MoveObject_KeyDown(object sender, KeyEventArgs e)
        {
            Control[] arr=this.Controls.Find(count.ToString(), false);
            PictureBox pic = (PictureBox)arr[0];
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pic.Left -= 5;
                    break;
                case Keys.Right:
                    pic.Left += 5;
                    break;
                case Keys.Up:
                    pic.Top -= 5;
                    break;
                case Keys.Down:
                    pic.Top += 5;
                    break;
            }
            if (pnBounds.Bounds.Contains(pic.Bounds))
            {
                pnBounds.Controls.Add(pic);
                AddNewPic();
            }
        }
    }
}
