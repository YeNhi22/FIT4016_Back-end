//Viết một hàm để tính tổng của tất cả các số chẵn trong một mảng.
Console.OutputEncoding = System.Text.Encoding.UTF8;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sum = SumEvenNumbers(numbers);

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

// Tính tổng các số chẵn trong mảng đã nhập
int sum1 = SumEvenNumbers(array);
Console.WriteLine("Tổng các số chẵn trong mảng là: " + sum1);
// Hàm tính tổng các số chẵn trong mảng
int SumEvenNumbers(int[] arr)
{
    int sum = 0;
    foreach (int num in arr)
    {
        if (num % 2 == 0)
        {
            sum += num;
        }
    }
    return sum;
}


