using System;

namespace Bai2_lap13
{
    internal class TaiLieu
    {
        public string maTL; // Mã tài liệu
        public string tenNXB; // Tên nhà xuất bản
        public int soBanPH; // Số bản phát hành

        public TaiLieu()
        {
            // Constructor mặc định
        }

        public TaiLieu(string maTL, string tenNXB, int soBan)
        {
            this.maTL = maTL;
            this.tenNXB = tenNXB;
            this.soBanPH = soBan;
        }

        public virtual void NhapThongTinCoBan()
        {
            Console.Write("+ Ma tai lieu: ");
            maTL = Console.ReadLine();
            Console.Write("+ Ten nha xuat ban: ");
            tenNXB = Console.ReadLine();
            Console.Write("+ So ban phat hanh: ");
            if (int.TryParse(Console.ReadLine(), out int soBan))
            {
                soBanPH = soBan;
            }
            else
            {
                Console.WriteLine("So ban phat hanh khong hop le.");
            }
        }

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"+ Ma tai lieu: {maTL}");
            Console.WriteLine($"+ Ten nha xuat ban: {tenNXB}");
            Console.WriteLine($"+ So ban phat hanh: {soBanPH}");
        }
    }
}