List<int> digits = new List<int>();
int modnum;

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int num = number;

do
{
    modnum = num % 10;
    digits.Add(modnum);
    num /= 10;
} while (num > 0);

bool isPol = true;
for (int i = 0; i < digits.Count / 2; i++)
{
    if (digits[i] != digits[(digits.Count - 1) - i])
        isPol = false;
}

if (isPol)
    Console.WriteLine("Число {0} является палиндромом", number);
else
    Console.WriteLine("Число {0} не является палиндромом", number);

// Console.Write("Ведите число: ");
// int number = int.Parse(Console.ReadLine() ?? "0");
// int mod = 0;
// int newmod = 0;
// int i = 0;
// for (i = number; number != 0; number = number / 10)
// {
//     mod = number % 10;
//     newmod = newmod * 10 + mod;
// }
// if (i == newmod) Console.WriteLine("Число палиндром");
// else Console.WriteLine("число не является палиндромом");