
var r = new Random();
int count = r.Next(1, 9);
int[] arr = new int[count];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next();
}

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}