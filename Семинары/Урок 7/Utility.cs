namespace Task
{
    delegate void MethodHandler();

    public static class Utility
    {
        public static List<int> GetDigitsNumber(int number)
        {
            int num = number;
            List<int> digits = new List<int>();
            int modNum;

            do
            {
                modNum = num % 10;
                digits.Add(modNum);
                num /= 10;
            } while (num > 0);

            return digits;
        }

        public static void DisplayArr<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }

            Console.WriteLine();
        }
        public static void DisplayArr<T>(T[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static int[,] CreateMatrix(int rows, int cols, int from = 1, int to = 10)
        {
            var matrix = new int[rows, cols];
            var r = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(from, to + 1);
                }
            }

            return matrix;
        }

        public static int[,] GetTransposeMatrix(int[,] matrix)
        {
            int[,] tMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tMatrix[j, i] = matrix[i, j];
                }
            }

            return tMatrix;
        }

        public static void TransposeMatrix(ref int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Swap(ref matrix[i, j], ref matrix[j, i]);
                }
            }
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public static int Power(int a, int n)
        {
            int res = 1;

            for (int i = 1; i <= n; i++)
            {
                res *= a;
            }

            return res;
        }

        public static int PowerRecursion(int a, int n)
        {
            if (a == 0 && n <= 0)
                throw new ArithmeticException("Для 0 степень должна быть > 0");

            if (a == 1 || a == 0) return a;

            return n > 1 ? a * PowerRecursion(a, n - 1) : a;
        }

    }
}