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

bool FindElement(int[,] arr, int element, out int indexR, out int indexC)
{
    indexR = -1;
    indexC = -1;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == element)
            {
                indexR = i;
                indexC = j;
                return true;
            }
        }
    }

    return false;
}

Console.Write("Введите кол-во строк: ");
var r = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите кол-во столбцов: ");
var c = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите элемент для поиска: ");
var element = int.Parse(Console.ReadLine() ?? "0");

var arr = GetFillArray(r, c);
DisplayArr(arr);

if (FindElement(arr, element, out int indexR, out int indexC))
{
    Console.WriteLine($"Элемент найден в строка: {indexR + 1} столбец: {indexC + 1}");
}
else
{
    Console.WriteLine("Элемент не найден");
}