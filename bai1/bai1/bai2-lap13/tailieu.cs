using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_lap13
{
    internal class tailieu
    {
        //khai báo các thuộc tính của tài liệu.
        protected string? maTL;
        protected string? TenNXB;
        protected int soBan;
        //phương thức khởi tạo mặc định.
        public tailieu()
        {

        }
        //phương thức khởi tạo có tham số
        public tailieu(string maTL, string TenNXB, int soBan)
        {
            this.maTL = maTL;
            this.TenNXB = TenNXB;
            this.soBan = soBan;
        }
        //phương thức nhập thông tin tài liệu
        public virtual void Nhap()
        {
            Console.Write("+ Ma tai lieu: ");
            maTL = Console.ReadLine();
            Console.Write("+ Ten nha xuat ban");
            TenNXB = Console.ReadLine();
            Console.Write("+ So ban: ");
            soBan = int.Parse(Console.ReadLine() ?? "0");


        }
        //phương thức hiển thị thông tin tài liệu
        public virtual void Xuat()
        {
            Console.WriteLine($"+ Ma tai lieu {maTL}");
            Console.WriteLine($"+ ten nha xuat ban {TenNXB}");
            Console.WriteLine($"+ So ban {soBan}");
        }
    }
}
