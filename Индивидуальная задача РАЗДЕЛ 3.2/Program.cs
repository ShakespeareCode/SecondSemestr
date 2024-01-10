using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Индивидуальная_задача_РАЗДЕЛ_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Дано натуральное число n (n<9999) и число m. Найти сумму m-последних цифр числа n.");
            //Console.WriteLine("введите число n (n<9999)");
            //uint n = uint.Parse(Console.ReadLine());
            //if (n > 9999)
            //{
            //    Console.WriteLine("error\a");
            //}

            //else
            //{
            //    Console.WriteLine("введите число m");
            //    uint m = uint.Parse(Console.ReadLine());
            //    if (m>=4)
            //    {
            //        Console.WriteLine("error\a");
            //    }

            //    uint sumDigits = 0;
            //    uint buf = n;

            //    for (int i = 0; i < m; i++)
            //    {
            //        uint lastDigit = buf % 10;  
            //        sumDigits += lastDigit;
            //        buf /= 10;
            //    }

            //    Console.WriteLine($"сумма {m}-последних цифр числа {n} {sumDigits}");
            //}
            //Console.ReadKey();

            Console.WriteLine("введите число");
            int number =int.Parse(Console.ReadLine());
            int lastDigit;
            int delimeter = 10;
            int result=0;
            int buf = number;
            while ((lastDigit = buf % delimeter) != 0)
            {
                result *= delimeter;
                result += lastDigit;
                buf /= 10;
            }
            Console.WriteLine($"source number = {number}; reverse number = {result}");

            Console.ReadKey();
            
        }
    }
}

