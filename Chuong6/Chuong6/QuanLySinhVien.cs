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
    
    public partial class QuanLySinhVien : Form
    {
        List<SinhVien> Students = new List<SinhVien>();
        public QuanLySinhVien()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            InsertSV();
        }

        private void InsertSV()
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string mssv = txtMSSV.Text;
            listView1.Items.Clear();
            AddtoListView();
            if (ten == "" || ho == "" || mssv == "")
            {
                MessageBox.Show("Điền đầy đủ thông tin sinh viên cần thêm!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SinhVien sv = new SinhVien(ho, ten, mssv);
            AddtoListView(sv);
            //them sv vô list
            Students.Add(sv);
            txtHo.Text = "";
            txtMSSV.Text = "";
            txtTen.Text = "";
            txtMSSV.Focus();
        }

        private void AddtoListView(SinhVien sv)
        {
            ListViewItem item = new ListViewItem(sv.mssv);
            item.SubItems.Add(sv.ho);
            item.SubItems.Add(sv.ten);
            listView1.Items.Add(item);
        }
        void AddtoListView()
        {
            foreach (SinhVien sv in Students)
            {
                AddtoListView(sv);
            }
        }
        private void btDel_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
               listView1.Items.Remove(listView1.SelectedItems[0]);
        }
 
        private void btFind_Click(object sender, EventArgs e)
        {
            string keyWork = txtTuKhoa.Text.ToLower();
            listView1.Items.Clear();
            foreach(SinhVien sv in Students)
            {
                if(sv.mssv.ToLower().Contains(keyWork)|| sv.ten.ToLower().Contains(keyWork))
                {
                    AddtoListView(sv);
                }
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            //sắp xếp trong list<SinhVien>
            Students.Sort((s1, s2) => s1.mssv.CompareTo(s2.mssv));
            listView1.Items.Clear();
            //thêm lại vào listView
            AddtoListView();
        }
    }
}
