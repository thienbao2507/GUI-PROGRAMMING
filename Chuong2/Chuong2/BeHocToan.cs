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
    public partial class BeHocToan : Form
    {
        public BeHocToan()
        {
            InitializeComponent();
            //add_Click();
        }
        Random rand = new Random();
        double Answer;
        List<Button> buttons;
        //private void add_Click()
        //{
        //    buttons = new List<Button>() { button0, button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        //    foreach (var item in buttons)
        //    {
        //        item.Click += new EventHandler(button_Click);
        //    }

        //}
        private void button_Click(object sender, EventArgs e)
        {
            string textButton = ((Button)sender).Text;
            txtAns.Text += textButton;
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            try
            {
                //random
                int number1 = rand.Next(11);
                int number2 = rand.Next(11);
                //clean textBox
                txtAns.Text = "";

                int calculation = rand.Next(0, 3);
                //show
                IbSo1.Text = number1.ToString();
                Ibso2.Text = number2.ToString();

                switch (3)
                {
                    case 0:
                        IbPhep.Text = "+";
                        Answer = number1 + number2;
                        break;
                    case 1:
                        IbPhep.Text = "-";
                        Answer = number1 - number2;
                        break;
                    case 2:
                        IbPhep.Text = "x";
                        Answer = number1 * number2;
                        break;
                    case 3:
                        IbPhep.Text = "/";
                        Answer = (double) number1 / number2;
                        break;
                }
            }
         
            catch (DivideByZeroException)
            {
                IbKetQua.Text = "Lỗi phép chia cho 0";
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            txtAns.Text = " ";
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtAns.Text) == Answer)
                    IbKetQua.Text = "Đúng rồi!!!";
                else
                    IbKetQua.Text = String.Format("Sai rồi! Kết quả là {0:0.##}", Answer);
            }
            catch(FormatException)
            {
                IbKetQua.Text = "Bạn chưa nhập đáp án!!!";
            }
            catch(OverflowException)
            {
                IbKetQua.Text = "lỗi tràn số!!!";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtAns.Text += bt.Text;
        }
    }
}
