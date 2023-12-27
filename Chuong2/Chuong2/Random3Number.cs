using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong2
{
    public partial class Random3Number : Form
    {
        Random random = new Random();
        int score = 0;
        public Random3Number()
        {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            int so1 = random.Next(1, 10);
            int so2 = random.Next(1, 10);
            int so3 = random.Next(1, 10);
            IbSo1.Text = so1.ToString();
            IbSo2.Text = so2.ToString();
            IbSo3.Text = so3.ToString();

            if (so1 == so2 && so2 == so3)
            {
                score += 10;
                IbScore.Text = score.ToString();
            }
            else
            {
                score -= 10;
                IbScore.Text = score.ToString();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
