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
    public partial class PTBac2 : Form
    {
        public PTBac2()
        {
            InitializeComponent();
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            double delta = b * b - 4 * a * c;
            if (delta<0)
            {
                lbAns.Text = "Phương trình không có nghiệm thực.";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                lbAns.Text = String.Format("Phương trình có nghiệm kép: x = {0}", x);
                
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                lbAns.Text = String.Format("Phương trình có hai nghiệm phân biệt:\n{0}\n{1}", x1,x2);
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
