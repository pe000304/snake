﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class point
    {
        public int x;
        public int y;
        public char sym;

        public point()
        {
            
        }

        public point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;

        }

        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;

            }
            else if (direction == Direction.LEFT)
                 {
                    x = x - offset;
                  }
                  else if (direction == Direction.UP)
                  {
                    y = y - offset;
                  }
                       else if (direction == Direction.DOWN)
                            {
                                y = y + offset;
                            }
        }


        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        } 


        /*public override string ToString()
        {
            return x + ', '+ y + ',' + sym;
        }*/


    }
}
