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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (addHead.Checked)
            {
                listBox1.Items.Insert(0, txtInput.Text);
            }
            else
            {
                listBox1.Items.Add(txtInput.Text);
            }
            txtInput.Text = "";
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (rLeftList.Checked){
                listBox1.Items.Clear();
                }
            else
            {
                listBox2.Items.Clear();
            }
        }

        private void btLeftToRight_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void btRightToLeft_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }
    }
}
