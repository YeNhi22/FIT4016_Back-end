//Viết chương trình nhập vào mảng gồm n phần tử nhập từ bàn phím. Viết hàm để kiểm
//tra xem một số có phải là số nguyên tố hay không, hiển thị chỉ số và giá trị của những phần tử là số nguyên tố trong mảng
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Nhập vào một số nguyên dương n: ");
int n = int.Parse(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhập phần tử thứ " + (i + 1) + ": ");
    array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Mảng đã nhập là: ");
for (int i = 0; i < n; i++)
{
    Console.Write(array[i] + " ");
}

// Kiểm tra và hiển thị các số nguyên tố trong mảng
for (int i = 0; i < n; i++)
{
    if (IsPrime(array[i]))
    {
        Console.WriteLine("Phần tử thứ " + i + " là số nguyên tố: " + array[i]);
    }
}
// Hàm kiểm tra số nguyên tố
bool IsPrime(int num)
{
    if (num < 2) return false;
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}

