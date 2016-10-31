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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
        
    }
}
