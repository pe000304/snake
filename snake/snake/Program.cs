using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            horizontial_lines up_line   = new horizontial_lines(0, 78, 0, '+');
            horizontial_lines down_line = new horizontial_lines(0, 78, 23, '+');
            vertical_lines left_line    = new vertical_lines(0, 23, 0, '+');
            vertical_lines right_line   = new vertical_lines(0, 23, 78, '+');

            up_line.Draw();
            down_line.Draw();
            left_line.Draw();
            right_line.Draw();

            point p1 = new point(4, 5, '*');
            snake snake = new snake(p1, 4, Direction.RIGHT);

            snake.Draw();
         
            FoodCreator foodCreater = new FoodCreator(80, 25, '$');
            point food = foodCreater.CreateFood();
            food.Draw();


            for(;;)
            {
                if (snake.Eat(food))
                {
                    food = foodCreater.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandKey(key.Key);
                }
                
            }

            //Console.ReadKey();
        }
               
    }
}
