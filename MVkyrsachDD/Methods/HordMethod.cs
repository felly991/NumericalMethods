using MVkyrsachDD.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVkyrsachDD.Methods
{
    internal class HordMethod : IFunc, IHord
    {
        double x, xn, xn1, e, dx = double.MaxValue;
        public int iter { get; set; } = 0;
        public HordMethod(double _e, double _x, double _xn)
        {
            e = _e;
            x = _x;
            xn = _xn;
        }
        
        public double Hord()
        {
            while (Math.Abs(dx) > e)
            {
                iter++;
                xn1 = xn;
                xn = x;
                x -= f(xn) * (xn - xn1) / (f(xn) - f(xn1));
                dx = x - xn;
            }
            return x;
        }
        public void Print()
        {
            Console.WriteLine($"Заданное уравнение x^2 - sin(x) = 0 \n" +
                $"Решим его методом хорд \n" +
                $"Имеет корень x = {Hord()} \n" +
                $"Количество итераций для поиска корня = {iter}");
        }
        public double f(double x)
        {
            return Math.Pow(x, 2) - Math.Sin(x);
        }
    }
}
