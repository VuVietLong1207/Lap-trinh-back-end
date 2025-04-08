using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Lap13
{
    internal class KySu : CanBo
    {
        private string? nganhDaoTao;

        public KySu()
        {
        }

        public KySu(string? hoTen, int namSinh, string? gioiTinh, string? diaChi, string? nganhDaoTao) : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            this.nganhDaoTao = nganhDaoTao;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("+ Nganh dao tao: ");
            nganhDaoTao = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ Nganh dao tao: {nganhDaoTao}");
        }
    }
}