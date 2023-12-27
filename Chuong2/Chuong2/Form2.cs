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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textSo1.Text);
                int b = int.Parse(textSo2.Text);
                if (rSum.Checked)
                    IbKetQua.Text = String.Format("{0:0}", checked(a + b));
                else if (rSub.Checked)
                    IbKetQua.Text = String.Format("{0:0}", checked(a - b));
                else if(rMul.Checked)
                    IbKetQua.Text = String.Format("{0:0}", checked(a * b));
                else if(rDivDu.Checked)
                    IbKetQua.Text = String.Format("{0:0}", checked(a % b));
                else if(rDiv.Checked)
                {
                    IbKetQua.Text = String.Format("{0:0.##}", (double) checked(a / b));
                }    
            }catch(FormatException)
            {
                IbKetQua.Text = "Bạn phải nhập đủ 2 số!!!";
            }
            catch(DivideByZeroException)
            {
                IbKetQua.Text = "Lỗi khi chia cho 0!!";
            }
            catch(OverflowException)
            {
                IbKetQua.Text = "Số quá lớn!!!";
            }
        }
    }
}
