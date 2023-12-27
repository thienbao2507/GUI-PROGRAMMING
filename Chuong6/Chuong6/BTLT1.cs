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
    public partial class BTLT1 : Form
    {
        Random rand = new Random();
        int[] arrInt;
        int[] arrPrime;
        int TongLe, TongChan;
        double TBC;
        
        public BTLT1()
        {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            try
            {
                int soPT = int.Parse(txtSoPT.Text);
                arrInt = new int[soPT];
                for (int i = 0; i < soPT; i++)
                {
                    arrInt[i] = rand.Next(0, 100);
                }
                showArray(arrInt);
            }
            catch (Exception)
            {
              
                MessageBox.Show("nhập số lượng pt");
            }

        }

        private void showArray(int []arr)
        {
            for (int i = 0; i <arr.Length ; i++)
            {
                txtInt.Text += (arr[i].ToString() + ",");
            }
            txtInt.Text = txtInt.Text.Substring(0, txtInt.Text.Length - 1);
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        
        private void btCal_Click(object sender, EventArgs e)
        {
            try {

                double Tong = 0;
                TongChan = 0;
                TongLe = 0;
                TBC = 0.0;
                int y=0;
                string arraySNT="";
                arrPrime = new int[100];
                for (int i = 0; i < arrInt.Length; i++)
                {
                    if (arrInt[i] % 2 == 0)
                        TongChan += arrInt[i];
                    if (arrInt[i] % 2 != 0)
                        TongLe += arrInt[i];
                    Tong += arrInt[i];
                }
                TBC = Tong / double.Parse(txtSoPT.Text);

                for (int i = 0; i < arrInt.Length; i++)
                {
                    if (IsPrime(arrInt[i]))
                    {
                        arraySNT += arrInt[i] + ",";                   
                    }
                }

                txtTongChan.Text = TongChan.ToString();
                txtTongLe.Text = TongLe.ToString();
                txtTBC.Text = TBC.ToString();
                txtSNT.Text = arraySNT.Substring(0,arraySNT.Length-1) ;
            }
            catch (Exception)
            {
                MessageBox.Show("nhập số lượng pt!!!!");
            }
            
        }

        private void AddNumber(int v)
        {
            int i = arrPrime.Length;
            arrPrime[i] = v;
        }
    }
}
