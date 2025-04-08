using System;

public class KiemTraSoChan
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap mot so nguyen: ");
        int soNguyen = int.Parse(Console.ReadLine());

        if (soNguyen % 2 == 0)
        {
            Console.WriteLine($"{soNguyen} la so chan.");
        }
        else
        {
            Console.WriteLine($"{soNguyen} khong phai la so chan.");
        }
    }
}