//Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Yêu cầu người dùng nhập một số nguyên
Console.Write("Nhập một số nguyên: ");
// Đọc giá trị nhập vào và chuyển đổi sang số nguyên
int number;
bool isValid = int.TryParse(Console.ReadLine(), out number);

if (isValid)
    Console.WriteLine("Số bạn nhập là: " + number);
else
{
    Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ.");
    return;
}
// Kiểm tra số nguyên tố
bool isPrime = true;
if (number < 2)
{
    isPrime = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}
