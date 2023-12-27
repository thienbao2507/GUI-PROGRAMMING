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
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }
        string pathImg = Application.StartupPath + @"\HinhXucXac\";
        Random rand = new Random();
        int nChoose;
        int nWin;
        int nLose;
        int nTime;
        String kq;
        private void bai3_Load(object sender, EventArgs e)
        {
           
            
        }

        public void Init()
        {
            nChoose = 1;
            nTime = nWin = nLose = 0;
            pic1 = null;
            listResult.Items.Clear();
            picResult = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            nChoose = int.Parse(bt.Text);
            pic1.Image = Image.FromFile(pathImg + nChoose.ToString()+".png");
        }

        private void btQuay_Click(object sender, EventArgs e)
        {
            //if (pic1 == null)
            //{
            //    MessageBox.Show("Bạn phải chọn số!!!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //}
            int so1 = rand.Next(1, 7);
            picResult.Image = Image.FromFile(pathImg + so1.ToString() + ".png");
            if (so1 == nChoose)
            {
                ++nWin;
                kq = "Thắng   ";
            }
            else
            {
                ++nLose;
                kq = "Sai    ";
            }
            ++nTime;
            lbTime.Text = String.Format("Số lần đoán: {0}", nTime);
            lbWin.Text = String.Format("Số lần đúng: {0} ({1:0.###}%)", nWin, (double) nWin * 100 / nTime);
            lbLose.Text = String.Format("Số lần sai: {0}  ({1:0.###}%)", nLose, (double)nLose * 100 / nTime);
            listResult.Items.Add(String.Format("{0}Đoán {1} ra{2}", kq, nChoose, so1));
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
            lbTime.Text = "";
            lbWin.Text = "";
            lbLose.Text = "";
        }
    }
}
