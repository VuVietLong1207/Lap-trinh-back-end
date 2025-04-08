using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Lap13
{
    internal class Bao : tailieu
    {
        private DateTime ngayPH;

        public Bao() { }

        public Bao(string maTL, string TenNXB, int soBan, DateTime ngayPH) : base(maTL, TenNXB, soBan)
        {
            this.ngayPH = ngayPH;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("+ Ngay phat hanh (yyyy-mm-dd): ");
            ngayPH = DateTime.Parse(Console.ReadLine() ?? DateTime.Now.ToString("yyyy-MM-dd"));
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ Ngay phat hanh: {ngayPH.ToString("yyyy-MM-dd")}");
        }
    }
}