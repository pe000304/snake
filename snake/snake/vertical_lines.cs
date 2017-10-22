﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class vertical_lines : figure
    {
        public vertical_lines(int yUp, int yDown, int x, char sym)
        {
            pList = new List<point>();

            for (int y = yUp; y <= yDown; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }
            
        }
                
    }
}
