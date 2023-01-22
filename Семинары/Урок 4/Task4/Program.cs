void Swap(string[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        var element = arr[(arr.Length - 1) - i];
        arr[(arr.Length - 1) - i] = arr[i];
        arr[i] = element;
    }
}

void DisplayArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите список фамилий брокеров через пробел:");
var str = (Console.ReadLine() ?? "");

var split = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

Swap(split);
DisplayArray(split);