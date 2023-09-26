using System.Runtime.InteropServices;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число first: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Введите число second: ");
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("\nМаксимальное число: " + mx(first, second));

            Changer(ref first, ref second);
            Console.WriteLine("\nfirst = " + first);
            Console.WriteLine("second = " + second);

            Console.Write("\nВведите число от которого нужно взять факториал: ");
            int fact = int.Parse(Console.ReadLine());
            Console.WriteLine(fact + "! = " + Factorial(fact));

            Console.WriteLine("\nВведите два числа для поиска НОД:");
            int test1 = int.Parse(Console.ReadLine());
            int test2 = int.Parse(Console.ReadLine());
            Console.WriteLine("НОД: " + Eucklid(test1, test2));

            Console.WriteLine("\nВведите номер числа ряда Фибоначчи: ");
            int F = int.Parse(Console.ReadLine());
            Console.WriteLine("n-ое значение: " + Fibonachi(F));
        }
        
        static int mx(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a)
            {
                return b;
            }
            else
            {
                return -1;
            }
        }

        static void Changer(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static int Eucklid(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int Fibonachi(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}