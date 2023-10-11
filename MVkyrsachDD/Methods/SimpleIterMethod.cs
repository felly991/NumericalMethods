using MVkyrsachDD.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVkyrsachDD.Methods
{
    internal class SimpleIterMethod : IFunc, ISimpleIter
    {
        double x0, e, x = 100;
        public int iter { get; set; } = 0;
        public SimpleIterMethod(double _e, double _x0) 
        {
            e = _e;
            x0 = _x0;
        }
        public double SimpleIter()
        {
             while (Math.Abs(x - x0) > e)
             {
                iter++;
                x = x0;
                x0 = f(x);
             }
            return x;
        }
        public void Print()
        {
            Console.WriteLine($"Заданное уравнение x^2 - sin(x) = 0 \n" +
                $"Решим его методом простых итераций \n" +
                $"Имеет корень x = {SimpleIter()} \n" +
                $"Количество итераций для поиска корня = {iter}");
        }
        public double f(double x)
        {
            return Math.Sqrt(Math.Sin(x)); 
        }
    }
}
