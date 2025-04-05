//Viết hàm để tìm số lớn thứ hai trong một mảng các số nguyên.
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Nhập vào một số nguyên dương n: ");
string input = Console.ReadLine();
if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Giá trị nhập vào không hợp lệ.");
    return;
}
int n = int.Parse(input);

int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Nhập phần tử thứ " + (i + 1) + ": ");
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Giá trị nhập vào không hợp lệ.");
        return;
    }
    array[i] = int.Parse(input);
}
Console.WriteLine("Mảng đã nhập là: ");
for (int i = 0; i < n; i++)
{
    Console.Write(array[i] + " ");
}

// Tìm số lớn thứ hai trong mảng
int secondLargest = FindSecondLargest(array);
Console.WriteLine("\nSố lớn thứ hai trong mảng là: " + secondLargest);

int FindSecondLargest(int[] arr)
{
    if (arr.Length < 2)
    {
        throw new ArgumentException("Mảng phải có ít nhất hai phần tử.");
    }

    int first = int.MinValue, second = int.MinValue;
    foreach (int num in arr)
    {
        if (num > first)
        {
            second = first;
            first = num;
        }
        else if (num > second && num != first)
        {
            second = num;
        }
    }

    if (second == int.MinValue)
    {
        throw new InvalidOperationException("Không tìm thấy số lớn thứ hai.");
    }

    return second;
}
