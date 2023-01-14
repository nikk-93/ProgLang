Console.Write("Введите число: ");
string? text = Console.ReadLine();
// int number = Convert.ToInt32(Console.ReadLine());
int number = text == null ? 0 : int.Parse(text);
Console.WriteLine("Квадрат числа: {0}", Math.Pow(number, 2));