using System;

public class HoanViSo
{
    // Hàm hoán vị hai số nguyên bằng cách sử dụng biến tạm
    public static void HoanVi(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void Main(string[] args)
    {
        Console.Write("Nhap so nguyen a: ");
        int soA = int.Parse(Console.ReadLine());

        Console.Write("Nhap so nguyen b: ");
        int soB = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTruoc khi hoan vi: a = {soA}, b = {soB}");

        // Gọi hàm hoán vị, sử dụng từ khóa 'ref' để truyền tham chiếu
        HoanVi(ref soA, ref soB);

        Console.WriteLine($"Sau khi hoan vi: a = {soA}, b = {soB}");
    }
}