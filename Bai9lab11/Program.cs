using System;

public class TinhGiaiThua
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap mot so nguyen duong n: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Khong the tinh giai thua cho so am.");
        }
        else
        {
            long giaiThua = 1; // Sử dụng long để tránh tràn số cho các giá trị lớn

            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }

            Console.WriteLine($"{n}! = {giaiThua}");
        }
    }
}