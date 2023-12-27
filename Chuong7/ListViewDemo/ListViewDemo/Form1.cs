using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace ListViewDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = Directory.GetLogicalDrives();
            
            // Điền danh sách ổ đĩa vào ComboBox
            cbDiaChi.Items.AddRange(drives);
        }

        private void cbDiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sel_drv = cbDiaChi.SelectedItem.ToString();

            listView1.Items.Clear();
            //lấy danh sách địa chỉ đường dẫn thư mục
            string[] directories = Directory.GetDirectories(sel_drv);

            //lấy danh sách các file
            string[] files = Directory.GetFiles(sel_drv);

            //thêm các thư mục vào danh sách 

            foreach(string directory in directories)
            {
                ListViewItem item = new ListViewItem(directory.Substring(3));
                item.SubItems.Add("");
                item.ImageIndex = 0;
                listView1.Items.Add(item);

            }    

            foreach(string file in files)
            {
                ListViewItem item = new ListViewItem(file);
                item.SubItems.Add(FormatFileSize( file.Length));
                item.ImageIndex = 1;
                listView1.Items.Add(item);
            }


        }
        string FormatFileSize(long fileSize)
        {
            if (fileSize < 1024)
            {
                return string.Format("{0} Byte", fileSize); // Byte
            }
            else if (((double)fileSize / 1024) < 1024)
            {
                return string.Format("{0:0.##} KB", (double)fileSize / 1024); // KB
            }
            else if (((double)fileSize / (1024 * 1024)) < 1024)
            {
                return string.Format("{0:0.##} MB", (double)fileSize / (1024 * 1024)); // MB
            }
            return string.Format("{0:0.##} GB", (double)fileSize / (1024 * 1024 * 1024)); // GB
        }
        private long CalculateDirectorySize(DirectoryInfo directoryInfo)
        {
            long size = 0;

            FileInfo[] files = directoryInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                size += file.Length;
            }

            DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                size += CalculateDirectorySize(subDirectory);
            }

            return size;
        }

    }

}
