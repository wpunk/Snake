﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();
            
            Point p2 = new Point(4,5,'#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5,10,8,'+');
            line.Draw();

            VerticalLine lineV = new VerticalLine(5, 10, 8, '+');
            lineV.Draw();

            Console.ReadLine();
        }
    }
}
