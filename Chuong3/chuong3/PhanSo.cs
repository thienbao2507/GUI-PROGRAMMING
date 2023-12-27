using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3
{
    class PhanSo
    {
        int tuSo, mauSo;
        public PhanSo()
        {
            tuSo = 0;
            mauSo = 1;
        }
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        public int ts
        {
            get { return tuSo; }
            set { this.tuSo = value; }
        }
        public int ms
        {
            get { return this.mauSo; }
            set { this.mauSo = value; }
        }
        public PhanSo Cong(PhanSo p)
        {
            PhanSo kq = new PhanSo();
            kq.tuSo = p.tuSo + this.tuSo;
            kq.mauSo = p.mauSo * this.mauSo;
            return kq;
        }
    }
}
