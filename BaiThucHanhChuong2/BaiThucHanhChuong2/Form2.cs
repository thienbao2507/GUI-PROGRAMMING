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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtSo1.Text);
                double b = double.Parse(txtSo2.Text);
                if (radCong.Checked)
                {
                    txtKetQua.Text = String.Format("{0}",checked(a + b));
                }
                else if (radTru.Checked)
                {
                    txtKetQua.Text = String.Format("{0}", a - b);
                }
                else if (radNhan.Checked)
                {
                    txtKetQua.Text = String.Format("{0}", checked(a * b));
                }
                else if (radChiaDu.Checked)
                {
                    txtKetQua.Text = String.Format("{0}", a % b);
                }
                else
                {
                    if (b == 0)
                        throw new DivideByZeroException();
                    txtKetQua.Text = String.Format("{0:0.##}", a / b);
                }
            }
            catch(FormatException)
            {
                txtKetQua.Text = "Bạn phải nhập đúng format!!!!";
            }
            catch (DivideByZeroException)
            {
                txtKetQua.Text = "Không được chia cho 0!!!";
            }
            catch (OverflowException)
            {
                txtKetQua.Text = "Bạn nhập số quá lớn!!!";
            }
        }
    }
}
