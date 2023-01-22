void FillArray(int[] arr)
{
    var r = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = r.Next(10);
    }
}

void DisplayArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

    Console.WriteLine();
}

void WriteMaxCount(int[] arr)
{
    int count = 0;
    int countMax = 0;
    int number = 0;

    for (int i = 0; i < arr.Length / 2; i++)
    {
        count = 0;

        for (int j = i; j < arr.Length; j++)
        {
            if (arr[i] == arr[j]) count++;
        }

        if (countMax <= count)
        {
            number = arr[i];
            countMax = count;
        }
    }

    Console.WriteLine(number);
    Console.WriteLine(countMax);
}

Console.Write("Введите размер массива: ");
var n = int.Parse(Console.ReadLine() ?? "0");
var arr = new int[n];

FillArray(arr);
DisplayArray(arr);
WriteMaxCount(arr);
