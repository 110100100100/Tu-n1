System.Console.Write("Nhập số tiên bạn muốn chuyển đổi: ");
string money = Console.ReadLine();
int USD = Convert.ToInt32(money);
int VND = USD * 24000;

System.Console.WriteLine(VND);