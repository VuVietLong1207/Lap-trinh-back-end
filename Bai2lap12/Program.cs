using System;

public class ArrayOperations
{
    // Hàm kiểm tra xem một số có phải là số nguyên tố hay không
    public static bool LaSoNguyenTo(int n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;

        // Kiểm tra các số chia hết cho 2 và 3
        if (n % 2 == 0 || n % 3 == 0) return false;

        // Kiểm tra các số có dạng 6k ± 1
        for (int i = 5; i * i <= n; i = i + 6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }

        return true;
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

        Console.WriteLine("\nCac phan tu la so nguyen to trong mang:");
        bool coSoNguyenTo = false;
        for (int i = 0; i < n; i++)
        {
            if (LaSoNguyenTo(mang[i]))
            {
                Console.WriteLine($"Chi so: {i}, Gia tri: {mang[i]}");
                coSoNguyenTo = true;
            }
        }

        if (!coSoNguyenTo)
        {
            Console.WriteLine("Khong co so nguyen to trong mang.");
        }
    }
}