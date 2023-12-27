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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

    

        private void btnView_Click(object sender, EventArgs e)
        {
            int input = int.Parse(txtInput.Text);
            int res = 0;

            int num_1 = int.Parse(num1.Text);
            int num_2 = int.Parse(num2.Text);
            
            switch (operatorr.Text)
            {
                case "+":
                    res = num_1 + num_2;
                    break;
                case "-":
                    res = num_1 - num_2;
                    break;
                case "x":
                    res = num_1 * num_2;
                    break;
                case "/":
                    res = num_1 / num_2;
                    break;
            }

            if(input != res)
                result.Text = String.Format("Sai rồi! Kết quả là {0}", res);
            else
                result.Text = "Đúng rồi!";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            txtInput.Text = this.Text;
        }

        private void value_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtInput.Text += button.Text;
        }

        private void backSpace_Click(object sender, EventArgs e)
        {
            String stopBack = "Chuỗi rỗng";
            if (!String.IsNullOrEmpty(txtInput.Text) && txtInput.Text.CompareTo(stopBack) != 0)
            {
                String s = txtInput.Text;
                s = s.Substring(0, s.Length - 1);
                txtInput.Text = s;
            }
            else
                txtInput.Text = stopBack;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            
            int n1 = rand.Next(10);
            num1.Text = n1.ToString();
            
            int n2 = rand.Next(10);
            num2.Text = n2.ToString();

            Char[] opers = { '+', '-', 'x', '/' };
            Char oper = opers[rand.Next(4)];
            operatorr.Text = oper.ToString();
        }
    }
}
