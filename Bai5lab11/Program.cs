using System;

public class TinhTongVaTich
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap so thu nhat: ");
        double so1 = double.Parse(Console.ReadLine());

        Console.Write("Nhap so thu hai: ");
        double so2 = double.Parse(Console.ReadLine());

        double tong = so1 + so2;
        double tich = so1 * so2;

        Console.WriteLine($"Tong hai so la: {tong}");
        Console.WriteLine($"Tich hai so la: {tich}");
    }
}