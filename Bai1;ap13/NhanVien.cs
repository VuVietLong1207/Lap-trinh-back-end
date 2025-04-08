using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    internal class NhanVien : CanBo
    {
        private string? congViec;

        public NhanVien()
        {
        }

        public NhanVien(string? hoTen, int namSinh, string? gioiTinh, string? diaChi, string? congViec) : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            this.congViec = congViec;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("+ Cong viec: ");
            congViec = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"+ Cong viec: {congViec}");
        }
    }
}