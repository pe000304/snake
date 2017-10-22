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
            Console.SetBufferSize(80, 25);

            //point p1 = new point(1, 3, '*');
            //p1.Draw();
            
            //point p2 = new point(4, 5, '#');
            //p2.Draw();

            horizontial_lines up_line   = new horizontial_lines(0, 78, 0, '+');
            horizontial_lines down_line = new horizontial_lines(0, 78, 23, '+');
            vertical_lines left_line    = new vertical_lines(0, 23, 0, '+');
            vertical_lines right_line   = new vertical_lines(0, 23, 78, '+');

            up_line.Draw();
            down_line.Draw();
            left_line.Draw();
            right_line.Draw();

            point p1 = new point(4, 5, '*');
            //p1.Draw();
            snake snake = new snake(p1, 4, Direction.RIGHT);
            snake.Draw();
            
            Console.ReadKey();
        }
               
    }
}
