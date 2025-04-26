using System;

namespace Bai2_TinhHinh
{
    public class HinhTamGiac : HInh
    {
        public double CanhA { get; set; }
        public double CanhB { get; set; }
        public double CanhC { get; set; }

        public HinhTamGiac(double canhA, double canhB, double canhC)
        {
            CanhA = canhA;
            CanhB = canhB;
            CanhC = canhC;
        }

        // Lưu ý: Đây là công thức Heron để tính diện tích tam giác khi biết 3 cạnh
        public override double TinhDienTich()
        {
            double p = (CanhA + CanhB + CanhC) / 2;
            return Math.Sqrt(p * (p - CanhA) * (p - CanhB) * (p - CanhC));
        }

        public override double TinhChuVi()
        {
            return CanhA + CanhB + CanhC;
        }
    }
}