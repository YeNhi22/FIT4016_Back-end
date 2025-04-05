//Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào [tên], bạn[tuổi] tuổi!"

//?? toán tử hợp nhất null
int? x = null;
int y = x ?? 100; //nếu x là null thì y sẽ là gtri 100
Console.WriteLine(y);

Console.OutputEncoding = System.Text.Encoding.UTF8;
//Khai báo biến
string? ten;
int tuoi;
//Nhập dữ liệu từ bàn phím
Console.Write("Nhập tên: ");
ten = Console.ReadLine();
Console.Write("Nhập tuổi: ");
tuoi = int.Parse(Console.ReadLine() ?? "0");
//nếu đúng trả về Console.ReadLine()
//nếu sai trả về "0"
//xuất ra màn hình
//Console.WriteLine("Xin chào" + ten + ", bạn" +tuoi+ "tuổi");
Console.WriteLine($"Xin chào {ten}, bạn {tuoi} tuổi"); //chuỗi nội suy 
