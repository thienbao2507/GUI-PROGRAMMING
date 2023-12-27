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
    public partial class bai4 : Form
    {
        public static string tenDangNhap;
        bool bClose = false;
        public bai4()
        {
           
            InitializeComponent();
            FormSignIn f1 = new FormSignIn();
            f1.ShowDialog();
        }
        
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "") return;
            ListViewItem item = new ListViewItem(txtTenNV.Text);
            item.SubItems.Add(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            item.SubItems.Add(rNam.Checked ? "Nam" : "Nữ");
            item.ImageIndex=(rNam.Checked ? 1 : 0);
            listView.Items.Add(item);
            txtTenNV.Text = "";
            txtTenNV.Focus();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView.SelectedItems)
            {
                listView.Items.Remove(item);
            }
        }

        private void bai4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bClose)
            {
                e.Cancel = true;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity <= 0)
            {
                bClose = true;
                this.Close();
            }
                

        }

        private void bai4_Load(object sender, EventArgs e)
        {
            lbten.Text = tenDangNhap;
        }
    }
}
