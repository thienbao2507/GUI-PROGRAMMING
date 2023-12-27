using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhChuong2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnChia_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            try
            {
                if (b == 0)
                    throw new DivideByZeroException();
                else
                    txtKetQua.Text = String.Format("{0:0.##}", a / b);
            }
            catch(DivideByZeroException){
                txtKetQua.Text = "Không thể chia cho 0";
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            txtKetQua.Text = String.Format("{0}", a * b);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            txtKetQua.Text = String.Format("{0}", a - b);
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSo1.Text);
            double b = double.Parse(txtSo2.Text);
            txtKetQua.Text = String.Format("{0}", a + b);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
