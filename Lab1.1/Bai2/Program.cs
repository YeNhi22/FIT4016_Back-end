//Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng.
Console.OutputEncoding = System.Text.Encoding.UTF8;

double chieuDai, chieuRong, dienTich;

//Nhập chiều dài và chiều rộng
Console.WriteLine("Nhập chiều dài: ");
chieuDai = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Nhập chiều rộng: ");
chieuRong = double.Parse(Console.ReadLine() ?? string.Empty);

//Tính diện tích
dienTich = chieuDai * chieuRong;

Console.WriteLine($"Diện tích của hình chữ nhật là: {dienTich}");
