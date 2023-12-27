using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3
{
    class HinhTron
    {
        Diem tam = new Diem(4, 5);
        public double banKinh;
        public HinhTron(Diem tam, double bk)
        {
            this.tam = tam;
            this.banKinh = bk;
        }
        public Diem Tam
        {
            get { return tam; }
            set { this.tam = value; }
        }
        public double BanKinh
        {
            get { return banKinh; }
            set { this.banKinh = value; }
        }
        public double DienTich()
        {
            return Math.PI * banKinh * banKinh;
        }
        public double ChuVi()
        {
            return 2 * Math.PI * banKinh;
        }
        public bool Contain(Diem d)
        {
            double a = d.HoanhDo - this.tam.HoanhDo;
            double b = d.TungDo - this.tam.TungDo;
            double distance = Math.Sqrt(a * a + b * b);
            if (banKinh - distance>0)
            {
                return true;
            }
            return false;
        }
    }
}
