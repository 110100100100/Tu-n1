double height;
double weight;

System.Console.WriteLine("Nhập chiều cao của ban: ");
height = double.Parse(Console.ReadLine());
System.Console.WriteLine("Nhập cân nặng của bạn: ");
weight = double.Parse(Console.ReadLine());

double bmi = weight / Math.Pow(height, 2);
Console.Write("BMI: " + bmi);

if (bmi < 18)
    Console.WriteLine(" Gầy");
else if (bmi < 25.0)
    Console.WriteLine(" Cân đối");
else if (bmi < 30.0)
    Console.WriteLine(" Hơi quá cỡ");
else
    Console.WriteLine(" Béo phì ");