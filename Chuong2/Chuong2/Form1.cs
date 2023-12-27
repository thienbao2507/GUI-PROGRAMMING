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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textSo1.Text);
            double b = double.Parse(textSo2.Text);
            double kq = a + b;
            IbKetQua.Text = String.Format("{0}", kq);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            
            try
            {
                double a = double.Parse(textSo1.Text);
                double b = double.Parse(textSo2.Text);
                IbKetQua.Text = String.Format("{0:0.##}", a / b);
             }
            catch(DivideByZeroException)
            {
                IbKetQua.Text = "Lỗi khi chia cho 0";
            }
            catch (FormatException)
            {
                IbKetQua.Text = "Bạn phải nhập đủ 2 số!!!!";
            }


        }

        private void btSub_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textSo1.Text);
            double b = double.Parse(textSo2.Text);
            double kq = a - b;
            IbKetQua.Text = String.Format("{0}", kq);
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textSo1.Text);
            double b = double.Parse(textSo2.Text);
            double kq = a * b;
            IbKetQua.Text = String.Format("{0}", kq);
        }
    }
}
