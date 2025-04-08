using System;

public class KiemTraNamNhuan
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap mot nam: ");
        int nam = int.Parse(Console.ReadLine());

        if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
        {
            Console.WriteLine($"{nam} la nam nhuan.");
        }
        else
        {
            Console.WriteLine($"{nam} khong phai la nam nhuan.");
        }
    }
}