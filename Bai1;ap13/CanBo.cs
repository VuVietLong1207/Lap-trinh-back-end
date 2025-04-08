using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    internal class CanBo
    {
        protected string? hoTen;
        protected int namSinh;
        protected string? gioiTinh;
        protected string? diaChi;

        public CanBo()
        {
        }

        public CanBo(string? hoTen, int namSinh, string? gioiTinh, string? diaChi)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
        }

        public virtual void Nhap()
        {
            Console.Write("+ Ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("+ Nam sinh: ");
            while (!int.TryParse(Console.ReadLine(), out namSinh) || namSinh <= 0 || namSinh > DateTime.Now.Year)
            {
                Console.WriteLine("Nam sinh khong hop le. Vui long nhap lai.");
                Console.Write("+ Nam sinh: ");
            }

            Console.Write("+ Gioi tinh: ");
            gioiTinh = Console.ReadLine();

            Console.Write("+ Dia chi: ");
            diaChi = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"+ Ho ten: {hoTen}");
            Console.WriteLine($"+ Nam sinh: {namSinh}");
            Console.WriteLine($"+ Gioi tinh: {gioiTinh}");
            Console.WriteLine($"+ Dia chi: {diaChi}");
        }

        public string? HoTenProp
        {
            get { return hoTen; }
        }
    }
}