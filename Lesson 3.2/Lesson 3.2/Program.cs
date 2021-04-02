using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number;

            do
            {
                string input = Console.ReadLine();

                bool resalt = int.TryParse(input, out number);
                if (resalt)
                {

                }
                else
                {
                    Console.WriteLine("Ошибка! Введите число.");
                }
                if (number > 0 && number % 2 == 1)
                    sum += number;

            } while (number != 0);

            Console.WriteLine($"Сумма нечетных положительных чисел =   {sum}");
            Console.ReadLine();
            Console.Clear();
        }
    }

}
