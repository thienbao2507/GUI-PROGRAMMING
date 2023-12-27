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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (radXoaTrai.Checked)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >=0; i--)
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else if(radXoaPhai.Checked)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String s = txtChuoi.Text;
            if (radThemDau.Checked)
            {
                listBox1.Items.Insert(0, s);
            }
            else if (radThemCuoi.Checked)
            {
                listBox1.Items.Add(s);
            }
            txtChuoi.Text = "";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }

        private void listBox2_ControlAdded(object sender, ControlEventArgs e)
        {
      
        }

        private void toRight_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void toLeft_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        
    }
}
