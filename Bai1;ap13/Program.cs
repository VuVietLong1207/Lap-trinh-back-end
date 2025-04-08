using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLCB qlcb = new QLCB();
            int choice;

            do
            {
                Console.WriteLine("\n--- CHUONG TRINH QUAN LY CAN BO ---");
                Console.WriteLine("1. Nhap thong tin can bo moi");
                Console.WriteLine("2. Tim kiem can bo theo ho ten");
                Console.WriteLine("3. Hien thi danh sach tat ca can bo");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Nhap lua chon: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            qlcb.NhapCanBo();
                            break;
                        case 2:
                            Console.Write("Nhap ho ten can tim kiem: ");
                            string tenTimKiem = Console.ReadLine();
                            qlcb.TimKiemTheoHoTen(tenTimKiem);
                            break;
                        case 3:
                            qlcb.HienThiDanhSachCanBo();
                            break;
                        case 0:
                            Console.WriteLine("Thoat chuong trinh. Xin chao!");
                            break;
                        default:
                            Console.WriteLine("Lua chon khong hop le. Vui long nhap lai.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot so hop le.");
                }
            } while (choice != 0);
        }
    }
}