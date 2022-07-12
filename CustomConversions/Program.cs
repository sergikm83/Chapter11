using System;

namespace CustomConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Conversions *****\n");
            // Создать экземпляр Rectangle
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();
            Console.WriteLine();
            // Преобразовать r в Square на основе высоты Rectangle
            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            Rectangle rect = new Rectangle(10, 5);
            DrawSquare((Square)rect);

        }
        static void DrawSquare(Square sq)
        {
            Console.WriteLine(sq.ToString());
            sq.Draw();
        }
    }
}
