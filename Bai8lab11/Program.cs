using System;

public class BangCuuChuong
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Bang cuu chuong {i}:");
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            Console.WriteLine();
        }
    }
}