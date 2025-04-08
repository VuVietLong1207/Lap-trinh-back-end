using System;

public class KiemTraSoAmDuong
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap mot so: ");
        double so = double.Parse(Console.ReadLine());

        if (so > 0)
        {
            Console.WriteLine($"{so} la so duong.");
        }
        else if (so < 0)
        {
            Console.WriteLine($"{so} la so am.");
        }
        else
        {
            Console.WriteLine($"{so} la so khong.");
        }
    }
}