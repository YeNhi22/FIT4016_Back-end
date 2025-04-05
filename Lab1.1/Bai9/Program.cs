//Viết chương trình tính giai thừa của một số nguyên dương n.
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Khai báo biến
int n;
long giaiThua = 1;
// Yêu cầu người dùng nhập một số nguyên dương
Console.Write("Nhập một số nguyên dương: ");
// Đọc giá trị nhập vào và chuyển đổi sang số nguyên
bool isValid = int.TryParse(Console.ReadLine(), out n);
if (isValid)
{
    // Kiểm tra xem n có phải là số nguyên dương hay không
    if (n < 0)
    {
        Console.WriteLine("Vui lòng nhập một số nguyên dương.");
    }
    else
    {
        // Tính giai thừa
        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }
        // Xuất kết quả
        Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
    }
}
else
{
    Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
}
