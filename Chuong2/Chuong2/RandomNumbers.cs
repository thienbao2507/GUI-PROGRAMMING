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
    public partial class RandomNumbers : Form
    {
        public RandomNumbers()
        {
            InitializeComponent();
        }
        Random Rand = new Random();
        int pointPlayer = 0;
        private void btRandom_Click(object sender, EventArgs e)
        {
           
            //random
            int so1 = Rand.Next(1, 7);
            int so2 = Rand.Next(1, 7);
            int so3 = Rand.Next(1, 7);
            int sum = so1 + so2 + so3;
            //show
            IbSo1.Text = so1.ToString();
            IbSo2.Text = so2.ToString();
            Ibso3.Text = so3.ToString();
            IbDiem.Text = pointPlayer.ToString();
            IbSum.Text = sum.ToString();
            //check
            if(bt1.Checked)
            {
                if (sum <= 10)
                    pointPlayer += 10;
                else
                    pointPlayer -= 10;
            } 
            else
            {
                if (sum > 10)
                    pointPlayer += 10;
                else
                    pointPlayer -= 10;
            }    
        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            IbSo1.Text = "";
            IbSo2.Text = "";
            Ibso3.Text = "";
            pointPlayer = 0;
            IbSum.Text = "";
            IbDiem.Text = "0";
        }
    }
}
