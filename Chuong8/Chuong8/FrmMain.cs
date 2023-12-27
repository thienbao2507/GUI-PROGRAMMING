using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong8
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuDrawText_Click(object sender, EventArgs e)
        {
            FrmDrawText f = new FrmDrawText();
            f.MdiParent = this;
            f.Show();
        }

        private void menuDrawImage_Click(object sender, EventArgs e)
        {
            FrmDrawImage f = new FrmDrawImage();
            f.MdiParent = this;
            f.Show();
        }
    }
}
