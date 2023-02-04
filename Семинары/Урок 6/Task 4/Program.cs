int[,] GetFillArray(int r, int c, int from = 0, int to = 10)
{
    var arr = new int[r, c];

    var random = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(from, to + 1);
        }
    }

    return arr;
}

void DisplayArr<T>(T[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

Console.Write("Введите кол-во строк: ");
var r = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите кол-во столбцов: ");
var c = int.Parse(Console.ReadLine() ?? "0");

DisplayArr(GetFillArray(r, c));



