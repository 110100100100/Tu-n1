float width;
float height; 

Console.Write("Nhập vào chiều dài: ");
width = float.Parse(Console.ReadLine());
Console.Write("Nhập chiều cao: ");
height = float.Parse(Console.ReadLine());

float area = width * height;
Console.WriteLine("Diện tích là: " + area);