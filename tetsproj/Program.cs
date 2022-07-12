using System;
using System.Linq;

namespace tetsproj
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,bool> filter =x =>
            {
                Console.WriteLine($"{x}");
                return x > 5;
            };
            int result = Enumerable.Range(1, 10)
                .Where(filter)
                .First();
            Console.WriteLine(result);
        }
    }
}
