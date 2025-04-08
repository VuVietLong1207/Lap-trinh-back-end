using System;

namespace Bai2_lap13
{
    internal class Sach : TaiLieu
    {
        public string tenTG; // Tên tác giả
        public int soTrang; // Số trang

        public Sach() : base()
        {
            // Constructor mặc định, gọi constructor của lớp cha
        }

        public override void NhapThongTin()
        {
            Console.WriteLine("\nNhap thong tin Sach:");
            base.NhapThongTinCoBan(); // Gọi phương thức nhập thông tin cơ bản từ lớp cha
            Console.Write("+ Ten tac gia: ");
            tenTG = Console.ReadLine();
            Console.Write("+ So trang: ");
            if (int.TryParse(Console.ReadLine(), out int soTr))
            {
                soTrang = soTr;
            }
            else
            {
                Console.WriteLine("So trang khong hop le.");
            }
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("\n--- Thong tin Sach ---");
            base.HienThiThongTin(); // Gọi phương thức hiển thị thông tin cơ bản từ lớp cha
            Console.WriteLine($"+ Ten tac gia: {tenTG}");
            Console.WriteLine($"+ So trang: {soTrang}");
        }
    }
}