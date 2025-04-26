using System;

namespace Bai1_lab1._5
{
    class PhanSoIO
    {
        public static PhanSo NhapPhanSo()
        {
            int tuSo;
            int mauSo;

            while (true)
            {
                Console.Write("Nhap tu so: ");
                if (int.TryParse(Console.ReadLine(), out tuSo))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot so nguyen.");
                }
            }

            while (true)
            {
                Console.Write("Nhap mau so: ");
                if (int.TryParse(Console.ReadLine(), out mauSo))
                {
                    if (mauSo != 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Mau so phai khac 0. Vui long nhap lai.");
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap mot so nguyen.");
                }
            }

            return new PhanSo(tuSo, mauSo);
        }

        public static void HienThiPhanSo(string message, PhanSo phanSo)
        {
            Console.Write($"{message} ");
            phanSo.Xuat();
        }
    }
}