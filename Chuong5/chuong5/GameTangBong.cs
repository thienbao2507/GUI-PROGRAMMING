using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong5
{
    public partial class GameTangBong : Form
    {
        int dx = 10;
        int dy = 10;
        int Point = 0;
        bool checkTimer = false;
        public GameTangBong()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cat.Left <= 0 || cat.Right >= ClientRectangle.Width)
            {
                dx = -dx;
            }
            if ( cat.Top <= 0)
            {
                dy = -dy;
            }
            cat.Left += dx;
            cat.Top += dy;
           

            if (pillow.Top - cat.Top >= 80 && pillow.Top - cat.Top <= 100)
            {
                if (cat.Left - pillow.Left > -50 && cat.Left - pillow.Left < 350)
                    dy = -dy;
            }
            if (cat.Bottom >= ClientRectangle.Height)
            {
                timer1.Stop();
                timer2.Stop();
                checkTimer = false;
                lbToaDo.Text = "Lose!!!";
                DialogResult result = MessageBox.Show(String.Format("bạn đạt {0} điểm",Point),"Noti", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {                
                    Restart();
                }
                else if (result == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                
            }
      
        }

        private void Restart()
        {
            cat.Left = ClientRectangle.Width / 2 - cat.Width / 2;
            cat.Top = 100;
            Point = 0;
        }

        private void GameTangBong_KeyDown(object sender, KeyEventArgs e)
        {
            int step = 50; // Độ dịch chuyển khi nhấn mỗi phím

            switch (e.KeyCode)
            {
                case Keys.A:
                    if (pillow.Left >= -10 && pillow.Left <= 10) { }
                    else
                        pillow.Left -= step;
                    break;
                case Keys.D:
                    if (pillow.Right >= ClientRectangle.Width - 10 && pillow.Right <= ClientRectangle.Width + 10) { }
                    else
                        pillow.Left += step;
                    break;
                case Keys.S:
                    if (checkTimer == true)
                    {
                        timer1.Stop();
                        timer2.Stop();
                        checkTimer = false;
                    }
                    else
                    {
                        timer1.Start();
                        timer2.Start();
                        checkTimer = true;
                    }
                    break;
            }
        }

        private void GameTangBong_Load(object sender, EventArgs e)
        {
            cat.BringToFront();
            pillow.Left = ClientRectangle.Width / 2 - pillow.Width / 2;
            cat.Left = ClientRectangle.Width / 2 - cat.Width / 2;
            cat.Top = 100;
            Point = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbToaDo.Text = string.Format("{0}", Point);
            Point += 10;
        }
    }
}
