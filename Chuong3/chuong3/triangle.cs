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
    public partial class triangle : Form
    {
        public triangle()
        {
            InitializeComponent();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            TamGiac tg1 = new TamGiac(double.Parse(txtCanhA.Text), double.Parse(txtCanhB.Text), double.Parse(txtCanhC.Text));
            DialogResult result;
            switch (tg1.Check_TG())
            {
                case 0:
                    result = MessageBox.Show("3 cạnh trên KHÔNG tạo thành tam giác!!", "Checked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    result = MessageBox.Show("3 cạnh trên tạo thành TAM GIÁC ĐỀU!!", "Checked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    result = MessageBox.Show("3 cạnh trên tạo thành TAM GIÁC CÂN!!", "Checked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 3:
                    result = MessageBox.Show("3 cạnh trên tạo thành TAM GIÁC!!", "Checked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btDT_Click(object sender, EventArgs e)
        {
            TamGiac tg1 = new TamGiac(double.Parse(txtCanhA.Text), double.Parse(txtCanhB.Text), double.Parse(txtCanhC.Text));
            DialogResult result = MessageBox.Show(String.Format("Diện tích hình tam giác là: {0:F2}", tg1.dienTich(), "Checked", MessageBoxButtons.OK, MessageBoxIcon.Question));
        }

        private void btChuVi_Click(object sender, EventArgs e)
        {
            TamGiac tg1 = new TamGiac(double.Parse(txtCanhA.Text), double.Parse(txtCanhB.Text), double.Parse(txtCanhC.Text));
            DialogResult result = MessageBox.Show(String.Format("Diện tích hình tam giác là: {0:F2}", tg1.chuVi(), "Checked", MessageBoxButtons.OK, MessageBoxIcon.Question));

        }
    }
}
