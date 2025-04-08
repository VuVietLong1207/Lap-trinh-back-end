// bài 4: viết chương trình nhập vào một số nguyên và kiểu tra xem có phải số chẵn hay không.   
Console.OutputEncoding = System.Text.Encoding.UTF8;
int x;

Console.WriteLine("Nhập x: ");

x = int.Parse(Console.ReadLine() ?? "");

try
{
   

    if (x % 2 == 0)
    {
        Console.WriteLine($"{x} là số chẵn");
    }
    else
    {
        Console.WriteLine($"{x} là số lẻ");
    }
}
catch (FormatException ex)
{
    Console.WriteLine("dữ liệu không hợp lệ" + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Lỗi : "+ ex.Message);
}