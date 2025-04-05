//Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F Công thức: F = (C * 9 / 5) + 32
Console.OutputEncoding = System.Text.Encoding.UTF8;

float C;
float F;

//Nhập độ C
Console.WriteLine("Nhập độ C: ");
C = float.Parse(Console.ReadLine() ?? "0");

//Công thức
F = (C * 9 / 5) + 32;
Console.WriteLine($"Nhiệt độ {C} độ, chuyển sang độ F là: {F} độ");
