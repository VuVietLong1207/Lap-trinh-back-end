using System;

public class ArrayOperations
{
    public static void DemSoAmDuong(int[] arr)
    {
        int countAm = 0;
        int countDuong = 0;

        foreach (int num in arr)
        {
            if (num < 0)
            {
                countAm++;
            }
            else if (num > 0)
            {
                countDuong++;
            }
        }

        Console.WriteLine($"So luong so am trong mang: {countAm}");
        Console.WriteLine($"So luong so duong trong mang: {countDuong}");
    }

    public static void Main(string[] args)
    {
        Console.Write("Nhap so luong phan tu cua mang (n): ");
        int n = int.Parse(Console.ReadLine());

        int[] mang = new int[n];

        Console.WriteLine("Nhap cac phan tu cua mang:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu thu {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        DemSoAmDuong(mang);
    }
}