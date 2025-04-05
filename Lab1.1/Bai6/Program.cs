//Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Yêu cầu người dùng nhập một số
Console.Write("Nhập một số: ");

// Đọc giá trị nhập vào và chuyển đổi sang số thực
double number;
bool isValid = double.TryParse(Console.ReadLine(), out number);

if (!isValid)
{
    Console.WriteLine("Vui lòng nhập một số hợp lệ.");
}
else
{
    // Kiểm tra số nhập vào là dương, âm hay không
    if (number > 0)
    {
        Console.WriteLine("Số bạn nhập là số dương.");
    }
    else if (number < 0)
    {
        Console.WriteLine("Số bạn nhập là số âm.");
    }
    else
    {
        Console.WriteLine("Số bạn nhập là số không.");
    }
}
;
