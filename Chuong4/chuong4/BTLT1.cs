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
    public partial class BTLT1 : Form
    {
        public BTLT1()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtBox1.Text);
        }

        private void btRtoL_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btLtoR_Click(object sender, EventArgs e)
        {     
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cyan")
            {
               listBox2.BackColor = Color.Cyan;
            }
            if (comboBox1.Text == "Red")
            {
                listBox2.BackColor = Color.Red;
            }
            if (comboBox1.Text == "Yellow")
            {
                listBox2.BackColor = Color.Yellow;
            }
            if (comboBox1.Text == "Blue")
            {
                listBox2.BackColor = Color.Blue;
            }
        }
    }
}
