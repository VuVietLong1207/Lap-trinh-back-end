using System;
using System.Linq;

public class ArrayOperations
{
    // Hàm sắp xếp mảng số thực theo chiều tăng dần (phiên bản đơn giản)
    public static void SapXepTangDanDonGian(double[] arr)
    {
        Array.Sort(arr); // Sử dụng phương thức Sort sẵn có
    }

    public static void Main(string[] args)
    {
        Console.Write("Nhap so luong phan tu cua mang (n): ");
        int n = int.Parse(Console.ReadLine());

        double[] mang = new double[n];

        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            mang[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nMang truoc khi sap xep:");
        Console.WriteLine(string.Join(", ", mang));

        SapXepTangDanDonGian(mang);

        Console.WriteLine("\nMang sau khi sap xep tang dan:");
        Console.WriteLine(string.Join(", ", mang));
    }
}