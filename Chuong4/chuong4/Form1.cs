using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong4
{
    public partial class Form1 : Form
    {
        string pathImg;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            lbName.Text = "    Trương Phan Thiên Bảo- 2151013008   ";
            pathImg = Application.StartupPath + @"\HinhXucXac\";
            pic1.Image = pic2.Image = pic3.Image = Image.FromFile(pathImg + "6.png");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(1) + lbName.Text.Substring(0, 1);
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            int so1 = rand.Next(1, 7);
            int so2 = rand.Next(1, 7);
            int so3 = rand.Next(1, 7);

            pic1.Image = Image.FromFile(pathImg + so1.ToString() + ".png");
            pic2.Image = Image.FromFile(pathImg + so2.ToString() + ".png"); 
            pic3.Image = Image.FromFile(pathImg + so3.ToString() + ".png");
            lbDiem.Text = (so1 + so2 + so3).ToString();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đóng?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
