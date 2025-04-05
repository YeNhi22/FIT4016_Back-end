//Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không.
//(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho 400).
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Yêu cầu người dùng nhập một năm
Console.Write("Nhập một năm: ");
// Đọc giá trị nhập vào và chuyển đổi sang số nguyên
int year;
bool isValid = int.TryParse(Console.ReadLine(), out year);
if (!isValid)
{
    Console.WriteLine("Vui lòng nhập một năm hợp lệ.");
}
else
{
    // Kiểm tra năm nhuận
    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    {
        Console.WriteLine($"{year} là năm nhuận.");
    }
    else
    {
        Console.WriteLine($"{year} không phải là năm nhuận.");
    }
}
