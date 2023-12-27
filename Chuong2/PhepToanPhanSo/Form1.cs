using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhepToanPhanSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PhanSo ps1, ps2;

        private void btCong_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string op = bt.Text;
            lbOP.Text = op;
            ps1.Tuso = int.Parse(txtTS1.Text);
            ps1.Mauso = int.Parse(txtMS1.Text);
            ps2.Tuso = int.Parse(txtTS2.Text);
            ps2.Mauso = int.Parse(txtMS2.Text);
            PhanSo kq = null;
            switch(op)
            {
                case "+": kq = ps1.congPhanSo(ps2); break;
                case "-":kq = ps1.truPhanSo(ps2); break;
                case "x":kq= ps1.nhanPhanSo(ps2); break;
                case "/":kq = ps1.chiaPhanSo(ps2); break;
            }
            txtTSkq.Text = kq.Tuso.ToString();
            txtMSkq.Text = kq.Mauso.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ps1 = new PhanSo();
            ps2 = new PhanSo();
        }
    }
}
