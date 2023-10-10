using MVkyrsachDD.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVkyrsachDD.Method
{
    public class NewtonMethod : INewton, IFunc
    {
        double e, x0, xn, xnp1, a, b;
        public double iter { get; set; } = 0;
        public NewtonMethod(double _e, double _a, double _b)
        {
            e = _e;
            a = _a;
            b = _b;
            x0 = a;
            if (SecondRate() * f(a) < 0)
            {
                x0 = b;
            }
            xn = x0 - f(x0) / Rate(x0);
            xnp1 = xn - f(xn) / Rate(xn);
        }
        public double Newton()
        {
            while (xn - xnp1 >= e)
            {
                iter += 1;
                xn = xnp1;
                xnp1 = xn - f(xn) / Rate(xn);
            }
            return xnp1;
        }
        public void Print()
        {
            Console.WriteLine($"Заданное уравнение x^2 - sin(x) = 0 \n" +
                $"Имеет корень x = {Newton()} \n" +
                $"Количество итераций для поиска корня = {iter}");
        }
        private double Rate(double x, double dx = 1E-12)
        {
            return (f(x + dx) - f(x)) / dx;
        }
        private double SecondRate(double x = Math.PI / 2, double dx = 1E-12)
        {
            return (f(x + dx) - 2 * f(x) + f(x - dx)) / (dx * dx);
        }

        public double f(double x)
        {
            return Math.Pow(x, 2) - Math.Sin(x);
        }
    }
}
