using System;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Overloaded Operators *****\n");
            // создать 2 точки
            Point pointOne = new Point(100, 100);
            Point pointTwo = new Point(40, 40);
            Console.WriteLine("Point one = {0}", pointOne);
            Console.WriteLine("Point two = {0}", pointTwo);
            // сложить 2 точки
            Console.WriteLine("point one + point two: {0}", pointOne + pointTwo);
            // вычесть одну точку из другой pointOne - pointTwo
            Console.WriteLine("point one - point two: {0}", pointOne - pointTwo);
            // вычесть одну точку из другой pointTwo - pointOne
            Console.WriteLine("point two - point one: {0}", pointTwo - pointOne);
            Point pointThree = pointOne + 25;
            Console.WriteLine("point one + 25 = {0}", pointThree);
            Console.WriteLine("17 + point three = {0}", 17 + pointThree);
            Point pointFour = new Point(0, 500);
            pointFour += pointThree;
            Console.WriteLine("point four + point three = {0}", pointFour);
            Console.WriteLine("point one == point two: {0}", pointOne == pointTwo);
        }
    }
}
