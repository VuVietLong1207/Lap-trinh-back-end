/*
//toán tử hợp nhất null
int? x = null;
int y = x ?? 100; // nếu x là null thì y là giá trị 100
Console.WriteLine(y);
//khai báo biến
*/
Console.OutputEncoding = System.Text.Encoding.UTF8;
string ten;
int tuoi;
// nnhập dữ liệu
Console.Write("nhap ten: ");
ten = Console.ReadLine();
Console.Write("nhap tuoi: ");
tuoi = int.Parse(Console.ReadLine()??"0");
// xuất ra màn hình
Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi.");// chuỗi nội dung
