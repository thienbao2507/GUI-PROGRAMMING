using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace chuong4
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            InitFontSize();
            InitFontList();
        }
        private void InitFontSize()
        {
            for(int i = 8; i <= 78; i+= 2)
            {
                cbSize.Items.Add(i.ToString());
            }
            cbSize.SelectedItem="10";
        }
        private void InitFontList()
        {
            InstalledFontCollection fontFamilies = new InstalledFontCollection();
            //FontFamily[] fontFamilies = FontFamily.Families;
            foreach (FontFamily family in fontFamilies.Families)
            {
                lbFont.Items.Add(family.Name);
            }
            lbFont.SelectedItem = "Arial";
        }


        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFont();
        }

        private void SetFont()
        {
            if (lbFont.Items.Count == 0) return;
            if (cbSize.Items.Count == 0) return;
            FontStyle style = FontStyle.Regular;
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFont();
        }
    }
}
