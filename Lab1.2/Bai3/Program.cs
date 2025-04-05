//Viết một hàm để đếm số lượng số âm và số dương trong một mảng gồm n phần tử nhập từ bàn phím
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

// Đếm số lượng số dương và số âm trong mảng
int positiveCount = 0;
int negativeCount = 0;
foreach (int num in array)
{
    if (num > 0)
    {
        positiveCount++;
    }
    else if (num < 0)
    {
        negativeCount++;
    }
}
Console.WriteLine("\nSố lượng số dương trong mảng là: " + positiveCount);
Console.WriteLine("Số lượng số âm trong mảng là: " + negativeCount);

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

