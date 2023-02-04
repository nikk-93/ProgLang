int[,] matrix = new int[2, 2] { { 0, 1 }, { 1, 1 } };

Console.Write("Введите число: ");
var num = int.Parse(Console.ReadLine() ?? "0");


var res = num == 1 ? matrix : MultMatrix(matrix, matrix);

for (int i = 0; i < num - 1; i++)
{
    res = MultMatrix(res, matrix);
}

DisplayArr(res);

static int[,] MultMatrix(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return r;
}

static void DisplayArr<T>(T[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}