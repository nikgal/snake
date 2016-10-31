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
            Console.ReadLine();
        }
        
    }
}
