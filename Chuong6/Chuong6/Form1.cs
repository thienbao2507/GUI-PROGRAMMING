using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtPos.Text);
            if (pos < 0 || pos > txtS1.Text.Length) return;
            txtS1.Text = txtS1.Text.Insert(pos, txtS2.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }

        private void btReplace_Click(object sender, EventArgs e)
        {
            txtS1.Text = txtS1.Text.Replace(txtS2.Text, txtS3.Text);
        }

        private void btDelS2inS1_Click(object sender, EventArgs e)
        {
            int pos = txtS1.Text.IndexOf(txtS2.Text);
            while (pos >= 0)
            {
                txtS1.Text = txtS1.Text.Remove(pos, txtS2.Text.Length);
                pos = txtS1.Text.IndexOf(txtS2.Text);
            }
        }

        private void btReverse_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = txtS1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);
            txtS1.Text = String.Join(" ", arr);
        }

        private void btChuanHoa_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };

            string[] arr = txtS1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);

            //duyét time phan tir trong mang, chuyén hoa ky ty dau, chuyén vé chir thudng c uv con Yf
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower();
            }
            txtS1.Text = String.Join(" ", arr);
        }
    }
}