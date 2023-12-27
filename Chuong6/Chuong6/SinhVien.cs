using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6
{
    class SinhVien
    {
        public string ho { get; set; }
        public string ten { get; set; }
        public string mssv { get; set; }

        public SinhVien(string ho, string ten,string mssv)
        {
            this.mssv = mssv;
            this.ho = ho;
            this.ten = ten;
        }
    }
}
