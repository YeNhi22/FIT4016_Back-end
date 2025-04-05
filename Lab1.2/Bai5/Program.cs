//Viết hàm hoán vị 2 số nguyên a và b nhập từ bàn phím.
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Nhập vào số nguyên a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Nhập vào số nguyên b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Trước khi hoán vị: a = " + a + ", b = " + b);
Swap(ref a, ref b);
Console.WriteLine("Sau khi hoán vị: a = " + a + ", b = " + b);
void Swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}
