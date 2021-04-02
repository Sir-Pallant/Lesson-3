using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._1
{ 
class Complex
{
    public double im, re;
    public Complex Sum(Complex a, Complex b)
    {
        Complex res = new Complex();
        res.im = a.im + b.im;
        res.re = a.re + b.re;
        return res;
    }

    public Complex Multiplication(Complex a, Complex b)
    {
        Complex res = new Complex();
        res.im = a.im * b.im;
        res.re = a.re * b.re;
        return res;
    }

    public Complex Minus(Complex a, Complex b)
    {
        Complex res = new Complex();
        res.im = a.im - b.im;
        res.re = a.re - b.re;
        return res;
    }

    public void Print(Complex a)
    {
        Console.Write("{0} + i{1}", a.im, a.re);
    }

    public void PrintLine(Complex a)
    {
        Console.WriteLine("{0} + i{1}", a.im, a.re);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите целую часть первого комплексного числа: ");
        double im1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите мнимую часть первого комплексного числа: ");
        double re1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите целую часть второго комплексного числа: ");
        double im2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите мнимую часть второго комплексного числа: ");
        double re2 = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Complex c1 = new Complex();
        Complex c2 = new Complex();
        c1.im = im1;
        c1.re = re1;
        c2.im = im2;
        c2.re = re2;
        Console.WriteLine("Введенные комплексные числа: ");
        c1.PrintLine(c1);
        c2.PrintLine(c2);

            Console.WriteLine("Введите математическую операцию:  '+' , '-' , '*' ");
            string result = Console.ReadLine();

          
            {
                Console.Clear();
                switch (result)
                {
                    case "+":
                        Console.WriteLine("Сложение комплексных чисел:       {0} + {1}i", c1.Sum(c1, c2).im, c1.Sum(c1, c2).re);
                        break;
                    case "-":
                        Console.WriteLine("Вычитание комплексных чисел:      {0} + {1}i", c1.Minus(c1, c2).im, c1.Minus(c1, c2).re);
                        break;
                    case "*":
                        Console.WriteLine("Умножение комплексных чисел:      {0} + {1}i", c1.Multiplication(c1, c2).im, c1.Multiplication(c1, c2).re);
                        break;
                    default:
                        Console.WriteLine("Вы ввели недопустимый символ");
                        break;
                }
                Console.ReadLine();
            }
             
         }
    }
}