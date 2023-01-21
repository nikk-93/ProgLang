var r = new Random();
int count = 12;
int[] arr = new int[count];
int posSum = 0;
int negSum = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(0, 10);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0) negSum += arr[i];
    else posSum += arr[i];
}

Console.WriteLine($"Сумма положительных чисел {posSum}");
Console.WriteLine($"Сумма отрицательных чисел {negSum}");