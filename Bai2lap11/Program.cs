using System;

public class TinhDienTichHinhChuNhat
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap chieu dai cua hinh chu nhat: ");
        double chieuDai = double.Parse(Console.ReadLine());

        Console.Write("Nhap chieu rong cua hinh chu nhat: ");
        double chieuRong = double.Parse(Console.ReadLine());

        double dienTich = chieuDai * chieuRong;

        Console.WriteLine($"Dien tich hinh chu nhat la: {dienTich}");
    }
}