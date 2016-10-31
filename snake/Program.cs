using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1,5, '#');
           
            p.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
                
            line.Draw();

            VerticalLine vLine = new VerticalLine(5, 10, 8, '*');
            vLine.Draw();

            Console.ReadLine();
        }
        
    }
}
