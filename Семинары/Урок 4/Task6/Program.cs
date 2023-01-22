void FillArray(int[] arr, int from = 0, int to = 10)
{
    var r = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = r.Next(from, to);
    }
}

void DisplayArray<T>(T[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }

    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
var n = int.Parse(Console.ReadLine() ?? "0");
var arrPos = new int[n / 2];
var arrNeg = new int[n / 2];
var arr = new int[arrNeg.Length + arrPos.Length];

FillArray(arrPos, 1, 11);
FillArray(arrNeg, -11, -1);

arrNeg.CopyTo(arr, 0);
arrPos.CopyTo(arr, arrNeg.Length);

DisplayArray(arrPos);
DisplayArray(arrNeg);
DisplayArray(arr);