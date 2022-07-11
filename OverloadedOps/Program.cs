using System;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fin with Overloaded Operators *****\n");
            // создать 2 точки
            Point pointOne = new Point(100, 100);
            Point pointTwo = new Point(40, 40);
            Console.WriteLine("Point one = {0}",pointOne);
            Console.WriteLine("Point two = {0}", pointTwo);
        }
    }
}
