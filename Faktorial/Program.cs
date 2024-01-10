using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("найти факториал выбраного пользователем числа");
            Console.WriteLine("введите число");
            ulong number = ulong.Parse(Console.ReadLine());
            try
            {
                ulong fibonacci = FactRecursive(number) * 1;
                Console.WriteLine($"Fibonacci = {fibonacci};");
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
        private static uint Fact(uint number)
        {
            uint fact = 1;
            for (uint i = 1; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }

        private static ulong FactRecursive(ulong number) =>
            number == 0 ? 1 : checked(FactRecursive(number - 1) * number);

        private static uint Fibonacci(uint number)
        {
            uint f0 = 0;
            uint f1 = 1;

            uint fn = 0;
            for (uint i = 2; i <= number; i++)
            {
                fn = f1 + f0;
                f0 = f1;
                f1 = fn;
            }
            return fn;
        }

        private static uint FibonacciRecursive(uint number)
        {
            if (number <= 2)
            {
                return 1;
            }
            return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
        }

        private static uint Recurus(uint number)
        {
            Console.WriteLine("Введите k, к<3: ");
            int k = int.Parse(Console.ReadLine());

            double multiplication = 1;
            int j = 0;

            if (j > k)
            {
                return 1;
            }

            for (j = -4; j <= k; j++)
            {
                double buf = Math.Pow(k, j + 2) * j / ((double)j - 3);
                if (buf != 0 && !double.IsInfinity(buf))
                {
                    multiplication *= buf;
                }
            }
            return (uint)multiplication;  
        }
    }
}

