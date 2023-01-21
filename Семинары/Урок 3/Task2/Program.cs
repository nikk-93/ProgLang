internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        var number = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine(number * (number + 1) / 2);
    }
}