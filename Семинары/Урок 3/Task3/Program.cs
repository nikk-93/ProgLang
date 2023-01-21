internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        var number = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine(GetDigitsNumber(number).Count);
    }

    public static List<int> GetDigitsNumber(int number)
    {
        int num = number;
        List<int> digits = new List<int>();
        int modnum;

        do
        {
            modnum = num % 10;
            digits.Add(modnum);
            num /= 10;
        } while (num > 0);

        return digits;
    }
}