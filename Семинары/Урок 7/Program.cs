using Task;

Dictionary<int, string> task = new()
{
    {1, "Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов."},
    {2, "Задан двумерный массив, заменяем строки на столбцы."},
};

Dictionary<int, MethodHandler> taskMethod = new()
{
    {1, CallTask1},
    {2, CallTask2},
};

while (true)
{
    Console.Clear();

    WriteTittle();

    string str = Console.ReadLine() ?? "0";
    if (!(int.TryParse(str, out int select) &&
        task.ContainsKey(select) &&
        taskMethod.TryGetValue(select, out var method)))
    {
        Console.WriteLine("Выход...");
        Console.ReadKey();
        return;
    }


    method();

    Console.WriteLine("Для продолжения нажмите любую клавишу...");
    Console.ReadKey();
}

void WriteTittle()
{
    foreach (var item in task)
    {
        Console.WriteLine($"{item.Key}. {item.Value}");
    }
    Console.WriteLine();
    Console.Write("Выберите задание: ");
}

void CallTask1()
{
    Console.WriteLine(task[1]);

    Console.Write("Введите кол-во строк: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов: ");
    int m = int.Parse(Console.ReadLine()!);

    var matrix = Utility.CreateMatrix(n, m);

    Utility.DisplayArr(matrix);

    int[] sumCol = new int[matrix.GetLength(1)];
    int[] avgCol = new int[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumCol[j] += matrix[i, j];
        }
    }

    Console.WriteLine("Суммы столбцов:");
    Utility.DisplayArr(sumCol);

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        avgCol[j] = sumCol[j] / matrix.GetLength(0);
    }

    Console.WriteLine("Среднее арифметическое столбцов:");
    Utility.DisplayArr(avgCol);
}

void CallTask2()
{
    Console.WriteLine(task[2]);

    Console.Write("Введите кол-во строк: ");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов: ");
    int m = int.Parse(Console.ReadLine()!);

    var matrix = Utility.CreateMatrix(n, m);

    Utility.DisplayArr(matrix);

    var tMatrix = Utility.GetTransposeMatrix(matrix);

    Console.WriteLine("Транспонированная матрица:");
    Utility.DisplayArr(tMatrix);

    if (n != m)
        return;

    Console.WriteLine("Транспонированная квадратная матрица:");
    Utility.TransposeMatrix(ref matrix);
    Utility.DisplayArr(matrix);
}


