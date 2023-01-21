Console.Write("Введите число: ");
var number = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Math.Pow(i, 2));
}