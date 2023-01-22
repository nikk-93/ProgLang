Console.Write("Введите число: ");
var number = int.Parse(Console.ReadLine() ?? "0");
var arr = new int[number];
var r = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(0, 2);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
