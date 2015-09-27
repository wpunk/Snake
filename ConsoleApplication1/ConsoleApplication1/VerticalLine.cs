﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yLeft, int yRight, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yLeft; y <= yRight; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }


        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();

            }
        }
    }
}
