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
            /*point p1 = new point(1, 3, '*');
            p1.Draw();
            
            point p2 = new point(4, 5, '#');
            p2.Draw();*/

            int x = 1;
            Func1(x);
            Console.WriteLine("Func1.x = " + x);

            x = 1;
            Func2(x);
            Console.WriteLine("Func2.x = " + x);

            x = 1;
            Func3(x);
            Console.WriteLine("Func3.x = " + x);



            point p1 = new point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move p1.x = " + p1.x + " p1.y = " + p1.y);




            point p2 = new point(4, 5, '#');
            p1 = p2;
            p2.x = 0;
            p2.y = 0;
            Console.WriteLine(" p1 = p2. p1.x = " + p1.x + ", p1.y" + p1.y + "; p2.x = " + p2.x + ", p2.y" + p2.y);

            //point p1 = new point(1, 3, '*');
            //Update(p1, 10, 10);
            //Console.WriteLine("Call Move p1.x = " + p1.x + " p1.y = " + p1.y);
            
            Console.ReadKey();
        }

        public static void Func1(int value)
        {
            
        }

        public static void Func2(int value)
        {
            value++;
        }

        public static void Func3(int x)
        {
            x++;
        }

        public static void Move(point p, int dx, int dy)
        {
            p.x += dx;
            p.y += dy;
        }



    }
}
