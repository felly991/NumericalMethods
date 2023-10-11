using MVkyrsachDD.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVkyrsachDD.Methods
{
    internal class HalfDivided : IFunc, IHalfDivided
    {
        double e, a, b, middle;
        public int iter { get; set; } = 0;
        public HalfDivided(double _e, double _a, double _b)
        {
            e = _e;
            a = _a;
            b = _b;
            middle = (a + b) / 2;
        }
        public double f(double x)
        {
            return Math.Pow(x, 2) - Math.Sin(x);
        }

        public double HalfDiv()
        {
            while (Math.Abs(b - a) >= 2 * e)
            {
                iter++;
                if ((f(a) * f(middle)) < 0)
                {
                    b = middle;
                }
                else
                {
                    a = middle;
                }
                middle = (a + b) / 2;
            }
            return middle;
        }
        public void Print()
        {
            Console.WriteLine($"Заданное уравнение x^2 - sin(x) = 0 \n" +
                $"Решим его методом половинного деления \n" +
                $"Имеет корень x = {HalfDiv()} \n" +
                $"Количество итераций для поиска корня = {iter}");
        }
    }
}
