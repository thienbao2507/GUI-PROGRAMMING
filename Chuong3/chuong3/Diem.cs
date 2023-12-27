using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuong3
{
    class Diem
    {
        double tungDo, hoanhDo;
        public Diem()
        {
            hoanhDo = 0;
            tungDo = 0;
        }
        public Diem(double x, double y)
        {
            this.hoanhDo = x;
            this.tungDo = y;
        }
        public double TungDo
        {
            get { return tungDo; }
            set { this.tungDo = value; }
        }
        public double HoanhDo
        {
            get { return hoanhDo; }
            set { this.hoanhDo = value; }
        }
    }
}
