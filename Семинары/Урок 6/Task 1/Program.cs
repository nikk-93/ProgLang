internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("1-ая сторона: ");
        var a = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("2-ая сторона: ");
        var b = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("3-ая сторона: ");
        var c = int.Parse(Console.ReadLine() ?? "0");

        // Неравенство треугольника
        if (a + b > c)
            Console.WriteLine("Можно построить треугольник");
        else if (a + b == c)
            Console.WriteLine("Можно построить вырожденный треугольник");
        else
            Console.WriteLine("Нельзя построить треугольник");
    }
}