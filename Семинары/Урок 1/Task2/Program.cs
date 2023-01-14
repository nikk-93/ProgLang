Console.Write("Введите первое число: ");
int firstNum = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int secondNum = int.Parse(Console.ReadLine() ?? "0");

// 1-ый способ
var max = Math.Max(firstNum, secondNum);
var min = Math.Min(firstNum, secondNum);

// // 2-ой способ
// if (firstNum > secondNum)
// {
//     max = firstNum;
//     min = secondNum;
// }
// else
// {
//     max = secondNum;
//     min = firstNum;
// }

Console.WriteLine("Максимальное число: {0}", max);
Console.WriteLine("Минимальное число: {0}", min);