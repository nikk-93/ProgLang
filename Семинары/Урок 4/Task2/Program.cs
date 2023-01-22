int FindMaxCount(int[] arr, int number)
{
    int index = 0;
    int count = 0;
    int countMax = 0;

    if (arr.Length == 0) return countMax;

    do
    {
        if (arr[index] == number) count++;
        else
        {
            if (countMax <= count) countMax = count;
            count = 0;
        }
        index++;
    } while (index < arr.Length);

    return countMax;
}

Console.Write("Введите размер массива: ");
var n = int.Parse(Console.ReadLine() ?? "0");
var arr = new int[n];
var r = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(0, 2);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}

Console.WriteLine();
Console.WriteLine(FindMaxCount(arr, 1));