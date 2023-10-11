using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVkyrsachDD.Graph
{
    internal class Graphics
    {
        public void Draw()
        {
            var list = new List<double>();
            int n = Console.BufferWidth, rows = Console.WindowHeight * 9 / 10;
            for (double d = -0.5; d <= 1.5; d += 0.1)
            {
                list.Add(Math.Pow(d, 2) - Math.Sin(d));
            }
            var coord = list.Select(x => (int)((x + 1) * rows / 2) + Console.WindowHeight / 20).ToArray();
            for (int i = 0; i < coord.Length; i++)
            {
                Console.SetCursorPosition(i, coord[i]);
                Console.Write('*');
            }
            Console.SetCursorPosition(0, 0);
            Console.ReadKey();
        }
    }
}
