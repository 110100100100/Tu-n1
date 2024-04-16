Console.WriteLine("Giải phương trình bậc nhất: ");
Console.WriteLine("Cho phương trình 'a * x + b = 0', hãy nhập hằng số:");

Console.Write("a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b: ");
double b = Convert.ToDouble(Console.ReadLine());

if (a != 0)
{
    double solution = -b / a;
    Console.Write("Kết quả là : {0}!", solution);
}
else
{
    if (b == 0)
        {
            Console.Write("Kết quả đúng với mọi x.");
        }
    else
        {
            Console.Write("Không có kết quả trả về.");
        }
}