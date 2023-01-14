Console.Write("Введите первое число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

for (int i = -number; i <= number; i++)
{
    Console.WriteLine(i);
}

// int current = -number;

// while (current <= number)
// {
//     Console.WriteLine(current);
//     current++;
// }