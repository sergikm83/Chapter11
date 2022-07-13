using System;
using System.Collections.Generic;

namespace InterfaceExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Extended Interface Compatible Types *****\n");
            // System.Array реализует IEnumerable!
            string[] data = { "Wow", "this", "is", "sort", "of", "annoying",
            "but","in","a","weird","way","fun"};
            data.PrintAndBeep();
            Console.WriteLine();
            // List<T> реализует IEnumerable!
            List<int> myInts = new List<int>() { 10, 15, 20, 25, 30 };
            myInts.PrintAndBeep();
        }
    }
}
