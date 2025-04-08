using System;

public class ChuyenDoiNhietDo
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap nhiet do (do C): ");
        string celsiusInput = Console.ReadLine();
        double celsius = Convert.ToDouble(celsiusInput);

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine(celsius + " do C tuong duong voi " + fahrenheit + " do F");
    }
}