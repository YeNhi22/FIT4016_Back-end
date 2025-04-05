//Viết chương trình in ra bảng cửu chương từ 1 đến 10.
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Khai báo biến
int i, j;
// Sử dụng vòng lặp for để in ra bảng cửu chương
for (i = 1; i <= 10; i++)
{
    for (j = 1; j <= 10; j++)
    {
        Console.Write($"{i} x {j} = {i * j}\t");
    }
    Console.WriteLine();
}
