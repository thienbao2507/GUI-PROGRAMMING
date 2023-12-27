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
    public partial class FormSignIn : Form
    {
        
        public FormSignIn()
        {
            InitializeComponent();
        }
     
        private void btSignIn_Click(object sender, EventArgs e)
        {
            bai4.tenDangNhap = txtName.Text;
            if (txtName.Text == "" || txtPass.Text != "admin")
            {
                Application.Exit();
                bai4.tenDangNhap = txtName.Text;
            }
            //else
            {
                txtName.Text = bai4.tenDangNhap;
                this.Close();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bai4.tenDangNhap == "")
            {
                Application.Exit();
            }
        }
    }
}
