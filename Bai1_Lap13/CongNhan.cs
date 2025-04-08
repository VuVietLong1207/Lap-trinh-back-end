using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Lap13
{
    internal class CongNhan : CanBo
    {
        private string? bac;

        public CongNhan()
        {
        }

        public CongNhan(string? hoTen, int namSinh, string? gioiTinh, string? diaChi, string? bac) : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            this.bac = bac;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("+ Bac cong nhan (VD: 3/7): ");
            bac = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ Bac: {bac}");
        }
    }
}