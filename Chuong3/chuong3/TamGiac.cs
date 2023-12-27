using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3
{
    class TamGiac
    {
        double canhA, canhB, canhC;
        public TamGiac()
        {
            canhA = 0;
            canhB = 0;
            canhC = 0;
        }
        public TamGiac(double a, double b, double c)
        {
            this.canhA = a;
            this.canhB = b;
            this.canhC = c;
        }
        public double CanhA
        {
            get { return canhA; }
            set { canhA = value; }
        }
        public double CanhB
        {
            get { return canhB; }
            set { canhB = value; }
        }
        public double CanhC
        {
            get { return canhC; }
            set { canhC = value; }
        }
        public int Check_TG()
        {
            if((canhA + canhB > canhC) && (canhA + canhC > canhB) && (canhB + canhC > canhA))
            {
                if ((canhA == canhB) && (canhA == canhC))
                {
                    return 1;//tam giac deu
                }
                else if ((canhA == canhB) || (canhA == canhC) || (canhB == canhC))
                {
                    return 2;//tam giac can
                }
                else
                    return 3;//tam gia thuong
            }
            else
                return 0;//khong phai tam giac
        }
        public double chuVi()
        {
            return (canhA + canhB + canhC);
        }
        public double dienTich()
        {
            double p = (canhA + canhB + canhC) / 2;
            double dienTich = Math.Sqrt(p * (p - canhA) * (p - canhB) * (p - canhC));
            return dienTich;
        }
    }
}
