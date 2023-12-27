using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BaiThucHanhChuong2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnConvert1_Click(object sender, EventArgs e)
        {
            int asciiNum = int.Parse(txtASCII.Text);
            convert1.Text = ((char)asciiNum).ToString();
        }

        private void btnCovert2_Click(object sender, EventArgs e)
        {
            char c = txtChar.Text[0];
            int asciiNum = (int)c;
            convert2.Text = asciiNum.ToString();
        }

        private void txtChar_TextChanged(object sender, EventArgs e)
        {
            TextBox txtC = (TextBox)sender;
            txtChar.MaxLength = 1;
            string input = txtC.Text;
            string pattern = "^[a-zA-Z]*$";

            if (!Regex.IsMatch(input, pattern))
                txtC.Text = "";
        }

        private void txtASCII_TextChanged_1(object sender, EventArgs e)
        {
            TextBox txtAscii = (TextBox)sender;
            string input = txtAscii.Text;
            int number;
            bool isNumber = int.TryParse(input, out number);

            if (!isNumber)
                txtAscii.Text = "";
        }
    }
}