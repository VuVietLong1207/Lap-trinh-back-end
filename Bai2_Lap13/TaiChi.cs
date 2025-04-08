using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Lap13
{
    internal class TapChi : tailieu
    {
        private int soPH;
        private int thangPH;

        public TapChi() { }

        public TapChi(string maTL, string TenNXB, int soBan, int soPH, int thangPH) : base(maTL, TenNXB, soBan)
        {
            this.soPH = soPH;
            this.thangPH = thangPH;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("+ So phat hanh: ");
            if (!int.TryParse(Console.ReadLine(), out soPH))
            {
                Console.WriteLine("So phat hanh khong hop le. Vui long nhap lai.");
                Nhap();
                return;
            }
            Console.Write("+ Thang phat hanh: ");
            if (!int.TryParse(Console.ReadLine(), out thangPH) || thangPH < 1 || thangPH > 12)
            {
                Console.WriteLine("Thang phat hanh khong hop le (1-12). Vui long nhap lai.");
                Nhap();
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ So phat hanh: {soPH}");
            Console.WriteLine($"+ Thang phat hanh: {thangPH}");
        }
    }
}