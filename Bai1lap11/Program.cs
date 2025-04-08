using System;

public class ChuongTrinhChaoMung
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap ten cua ban: ");
        string ten = Console.ReadLine();

        Console.Write("Nhap tuoi cua ban: ");
        int tuoi = int.Parse(Console.ReadLine());

        Console.WriteLine($"Xin chao {ten}, ban {tuoi} tuoi!");
    }
}