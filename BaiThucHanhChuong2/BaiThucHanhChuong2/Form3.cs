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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void selectBox_Enter(object sender, EventArgs e)
        {

        }

        private void lbDiem_Click(object sender, EventArgs e)
        {

        }

        private void run_Click(object sender, EventArgs e)
        {
            // Set min max
            int min, max;
            if (choice1.Checked)
            {
                min = 3;
                max = 10;
            }
            else
            {
                min = 11;
                max = 18;
            }

            // Random values
            Random rand = new Random();
            Label[] lbs = { num1, num2, num3 };
            int sum = 0;

            for (int i = 0; i < 3; i++)
            {
                int rand_num = rand.Next(10);
                lbs[i].Text = String.Format("{0}", rand_num);
                sum += rand_num;
            }

            // Update score
            int score = int.Parse(result.Text);
            if (sum <= max && sum >= min)
            {
                score += 10;
            }
            else score -= 10;

            // Return result 
            result.Text = String.Format("{0}", score);
        }
    }
}
