using System;

public class KiemTraSoNguyenTo
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap mot so nguyen duong: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 1)
        {
            Console.WriteLine($"{n} khong phai la so nguyen to.");
        }
        else
        {
            bool laSoNguyenTo = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    laSoNguyenTo = false;
                    break;
                }
            }

            if (laSoNguyenTo)
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }
    }
}