using System;

namespace Bai2_lap13
{
    internal class TapChi : TaiLieu
    {
        public int soPH; // Số phát hành
        public int thangPH; // Tháng phát hành

        public TapChi() : base()
        {
            // Constructor mặc định, gọi constructor của lớp cha
        }

        public override void NhapThongTin()
        {
            Console.WriteLine("\nNhap thong tin Tap chi:");
            base.NhapThongTinCoBan(); // Gọi phương thức nhập thông tin cơ bản từ lớp cha
            Console.Write("+ So phat hanh: ");
            if (int.TryParse(Console.ReadLine(), out int so))
            {
                soPH = so;
            }
            else
            {
                Console.WriteLine("So phat hanh khong hop le.");
            }
            Console.Write("+ Thang phat hanh: ");
            if (int.TryParse(Console.ReadLine(), out int thang))
            {
                thangPH = thang;
            }
            else
            {
                Console.WriteLine("Thang phat hanh khong hop le.");
            }
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("\n--- Thong tin Tap chi ---");
            base.HienThiThongTin(); // Gọi phương thức hiển thị thông tin cơ bản từ lớp cha
            Console.WriteLine($"+ So phat hanh: {soPH}");
            Console.WriteLine($"+ Thang phat hanh: {thangPH}");
        }
    }
}