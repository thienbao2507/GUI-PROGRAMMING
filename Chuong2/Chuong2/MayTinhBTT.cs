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
    public partial class MayTinhBTT : Form
    {
        double kq = 0.0;
        public MayTinhBTT()
        {
            InitializeComponent();
        }

        private void MayTinhBTT_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtShow.Text += bt.Text;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            txtShow.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            string str = txtShow.Text;
            txtShow.Text = "";
            string[] splitString = str.Split('+', '-', '*', '/');
            kq = double.Parse(splitString[0]);
            if (str.Contains('+'))
            {
                kq += double.Parse(splitString[1]);
                txtShow.Text = kq.ToString();
            }
            if (str.Contains('-'))
            {
                kq -= double.Parse(splitString[1]);
                txtShow.Text = kq.ToString();
            }
            if (str.Contains('*'))
            {
                kq *= double.Parse(splitString[1]);
                txtShow.Text = kq.ToString();
            }
            if (str.Contains('/'))
            {
                kq /= double.Parse(splitString[1]);
                txtShow.Text = string.Format("{0:F3}", kq);
            }
        }
    }
}
