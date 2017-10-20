using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point(1, 3, '*');
            p1.Draw();
            
            point p2 = new point(4, 5, '#');
            p2.Draw();

            horizontial_lines line = new horizontial_lines(5, 10, 8, '+');
            line.Draw();

            vertical_lines vertical = new vertical_lines(12, 12, 3, '*');
            line.Draw();

            Console.ReadKey();
        }
               
    }
}
