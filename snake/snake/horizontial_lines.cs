using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class horizontial_lines
    {
        List <point> pList;

        public horizontial_lines(int xLeft, int xRight, int y, char sym)
        {
            pList = new List <point>();

            for (int x = xLeft; x <= xRight; x++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }  

            
            /*point p1 = new point(4, 4, '*');
            point p2 = new point(5, 4, '*');
            point p3 = new point(6, 4, '*');

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);*/


        }

        public void Draw()
        {
            foreach (point p in pList)
            {
                p.Draw();
            }
               
        }     
    }
}
