internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Число в десятичной системе: ");
        var num = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine(DecToBin(num));
    }

    static double DecToBin(int dec)
    {
        double bin = 0;
        int pow = 0;

        int div = dec;

        while (true)
        {
            int mod = div % 2;
            bin += (Math.Pow(10, pow) * mod);
            
            div = div / 2;
            pow++;

            if (div == 0)
                break;
        }

        return bin;
    }

    static List<int> GetDigitsNumber(int number)
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

    static void DisplayArray<T>(T[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }
}