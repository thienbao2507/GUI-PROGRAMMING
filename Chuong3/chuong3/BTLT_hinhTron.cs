using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong3
{
    public partial class BTLT_hinhTron : Form
    {
        public BTLT_hinhTron()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Substring(1) + txtName.Text.Substring(0, 1);
        }

        private void btDo_Click(object sender, EventArgs e)
        {
            Diem d = new Diem(double.Parse(txtHoanhDo.Text), double.Parse(txtTungDo.Text));
            Diem d2= new Diem(double.Parse(DHoanhDo.Text), double.Parse(DTungDo.Text));
            HinhTron ht = new HinhTron(d, double.Parse(txtBanKinh.Text));
            txtCV.Text = ht.ChuVi().ToString();
            txtDT.Text = ht.DienTich().ToString();
            txtCheck.Text = ht.Contain(d2).ToString();
        }
    }
}
