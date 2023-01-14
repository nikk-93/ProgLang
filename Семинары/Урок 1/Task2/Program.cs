Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine() ?? "0");

// 1-ый способ
Console.WriteLine("Максимальное число: {0}", Math.Max(firstNum, secondNum));

Console.WriteLine("Минимальное число: {0}", Math.Min(firstNum, secondNum));

// 2-ой способ
if (firstNum > secondNum)
{
    Console.WriteLine("Максимальное число: {0}", firstNum);
    Console.WriteLine("Минимальное число: {0}", secondNum);
}
else
{
    Console.WriteLine("Максимальное число: {0}", secondNum);
    Console.WriteLine("Минимальное число: {0}", firstNum);
}