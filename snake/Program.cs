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
            Point p = new Point();
            p.x = 1;
            p.y = 5;
            p.sym = '#';
            p.Draw();
            Console.ReadLine();
        }
        
    }
}
