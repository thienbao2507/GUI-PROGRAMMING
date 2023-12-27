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
    public partial class bai2 : Form
    {
        int[] arrInt;
        int[] arrTang;
        int[] arrGiam;
        int[] arrDao;
        int[] arrChanLe;
        Random rand = new Random();
        public bai2()
        {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            //txtChanLe.Text = "";
            //txtDao.Text = "";
            //txtGiam.Text = "";
            //txtInt.Text = "";
            //txtTang.Text = "";
            try
            {
                int sopt = int.Parse(txtSoPT.Text);
                arrInt = new int[sopt];
                for (int i = 0; i < sopt; i++)
                {
                    arrInt[i] = rand.Next(100);
                }
                showArray(arrInt, txtInt);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void showArray(int[] arr, TextBox textbox)
        {
            textbox.Text = String.Empty;
            for(int i =0; i < arr.Length; i++)
            {
                textbox.Text += arr[i].ToString() + ",";
            }
            textbox.Text = textbox.Text.TrimEnd(',');
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            Sort();
            SortSpecial();
        }

        private void SortSpecial()
        {
            try
            {
                arrChanLe = new int[arrInt.Length];
                Array.Copy(arrInt, arrChanLe, arrInt.Length);
                int i = 0;
                int j = arrInt.Length - 1;
                while (i < j)
                {
                    if (arrChanLe[i] % 2 == 0)
                        i++;
                    if (arrChanLe[j] % 2 != 0)
                        j--;
                    if (i < j)
                    {
                        if (arrChanLe[i] % 2 != 0 && arrChanLe[j] % 2 == 0)
                        {
                            swap(ref arrChanLe[i], ref arrChanLe[j]);
                            i++;
                            j--;
                        }
                    }
                }
                int mid = arrChanLe[i] % 2 != 0 ? i - 1 : i;
                for(i =0; i< mid; i++)
                {    
                    for(j =i+1; j<mid+1;j++)
                    {
                        if(arrChanLe[i]<arrChanLe[j])
                            swap(ref arrChanLe[i], ref arrChanLe[j]);
                    }
                }
                for (i = mid+1; i < mid; i++)
                {
                    for (j = i + 1; j < mid + 1; j++)
                    {
                        if (arrChanLe[i] > arrChanLe[j])
                            swap(ref arrChanLe[i], ref arrChanLe[j]);
                    }
                }
                showArray(arrChanLe, txtChanLe);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void swap(ref int v1, ref int v2)
        {
            int t = v1;
            v1 = v2;
            v2 = t;
        }

        private void Sort()
        {
            try
            {
                arrTang = new int[arrInt.Length];
                arrGiam = new int[arrInt.Length];
                arrDao = new int[arrInt.Length];

                Array.Copy(arrInt, arrTang, arrInt.Length);
                Array.Sort(arrTang);
                showArray(arrTang, txtTang);

                Array.Copy(arrTang, arrGiam, arrInt.Length);
                Array.Reverse(arrGiam);
                showArray(arrGiam, txtGiam);

                Array.Copy(arrInt, arrDao, arrInt.Length);
                Array.Reverse(arrDao);
                showArray(arrDao, txtDao);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bai2_Load(object sender, EventArgs e)
        {
            txtSoPT.Text = 10.ToString();
        }
    }
}
