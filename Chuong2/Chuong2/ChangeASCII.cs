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
    public partial class ChangeASCII : Form
    {
        public ChangeASCII()
        {
            InitializeComponent();
        }



 

        private void btChangeASCtoChar_Click_1(object sender, EventArgs e)
        {
            try
            {
                char a = Convert.ToChar(int.Parse(txtASC.Text));

                lbChar.Text = a.ToString();
            }

            catch (FormatException)
            {
                string message = "Bạn phải nhập đúng mã ASCII trước";
                string title = "Lỗi";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(char.Parse(txtChar.Text));
                lbASC.Text = a.ToString();
            }

            catch (FormatException)
            {
                string message = "Bạn phải nhập đúng ký tự trước";
                string title = "Lỗi";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            }
        }
    }
    
}
