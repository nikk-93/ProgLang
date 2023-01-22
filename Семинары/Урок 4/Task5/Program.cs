void FillArray(int[] arr, int from = 0, int to = 10)
{
    var r = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = r.Next(from, to);
    }
}

void SwapElemnts(int[] arr)
{
    int toIndex = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0)
        {
            var element = arr[toIndex];
            arr[toIndex] = arr[i];
            arr[i] = element;
            toIndex++;
        }
    }

}

void ReplaceElements(int[] arr)
{
    int[] newArr = new int[arr.Length];
    int zeroIndex = 0;
    int otherIndex = arr.Length - 1;

    for (int i = arr.Length - 1; i >= 0; i--)
    {
        if (arr[i] == 0) newArr[zeroIndex++] = arr[i];
        else newArr[otherIndex--] = arr[i];
    }

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = newArr[i];
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
var arr = new int[] { -1, -3, -1, -3, -1, 0, -4, -2 };

//FillArray(arr, -n, n + 1);

DisplayArray(arr);

var arrSwap = (int[])arr.Clone();
var arrReplace = (int[])arr.Clone();

SwapElemnts(arrSwap);
ReplaceElements(arrReplace);

DisplayArray(arrSwap);
DisplayArray(arrReplace);