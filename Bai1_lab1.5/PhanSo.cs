using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_lab1._5
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;
        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }
        public void Xuat()
        {
            Console.WriteLine($"{tuSo}/{mauSo}");
        }
        public void RutGon()
        {
            int gcd = GCD(tuSo, mauSo);
            tuSo /= gcd;
            mauSo /= gcd;
        }
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
