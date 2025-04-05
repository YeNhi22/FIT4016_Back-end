//Viết hàm sắp xếp mảng số thực n phần tử nhập từ bàn phím theo chiều tăng dần.
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Nhập vào một số nguyên dương n: ");
string input = Console.ReadLine();
if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Giá trị nhập vào không hợp lệ.");
    return;
}
int n = int.Parse(input);
double[] array = new double[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhập phần tử thứ " + (i + 1) + ": ");
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Giá trị nhập vào không hợp lệ.");
        return;
    }
    array[i] = double.Parse(input);
}
Console.WriteLine("Mảng đã nhập là: ");
for (int i = 0; i < n; i++)
{
    Console.Write(array[i] + " ");
}
// Sắp xếp mảng theo chiều tăng dần
Array.Sort(array);
Console.WriteLine("\nMảng sau khi sắp xếp theo chiều tăng dần là: ");
for (int i = 0; i < n; i++)
{
    Console.Write(array[i] + " ");
}
