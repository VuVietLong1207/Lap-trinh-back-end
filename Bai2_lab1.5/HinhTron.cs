using System;

namespace Bai2_TinhHinh
{
    public class HinhTron : HInh
    {
        public double BanKinh { get; set; }

        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }

        public override double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * BanKinh * BanKinh;
        }
    }
}