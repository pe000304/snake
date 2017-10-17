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
            point p1 = new point();

            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            //Draw(p1.x, p1.y, p1.sym);

            /*int x1 = 1;
            int y1 = 3;
            char symbol_1 = '*';

            Draw(x1, y1, symbol_1); */


            point p2 = new point();

            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();
            
            //Draw(p2.x, p2.y, p2.sym);

            /*
            int x2 = 4;
            int y2 = 5;
            char symbol_2 = '#';

            Draw(x2, y2, symbol_2);*/
            Console.ReadKey();
        }



        /*static void Draw(int x, int y, char symb)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symb);
        }*/
    }
}
