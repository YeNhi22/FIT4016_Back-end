Console.OutputEncoding = System.Text.Encoding.UTF8;

//Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
int a, b;
Console.WriteLine("Nhập số a: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Nhập số b: ");
b = int.Parse(Console.ReadLine());

int sum = a + b;
int product = a * b;

Console.WriteLine($"Tổng của {a} và {b} là: {sum}");
Console.WriteLine($"Tích của {a} và {b} là: {product}");
