using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ExtensionMethods
{
    static class MyExtensions
    {
        // Этот метод позволяет объекту любого типа
        // отобразить сборку, в которой он определен.
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: {1}\n", obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }
        // Этот метод позволяет любому целочисленному значению изменить порядок
        // следования десятичных цифр на обратный.
        public static int ReverseDigits (this int i)
        {
            // Транслировать int в string и затем получить все его символы.
            char[] digits = i.ToString().ToCharArray();
            // изменить порядок следования элементов массива.
            Array.Reverse(digits);
            // поместить инвертированный массив символов в строку.
            string newDigits = new string(digits);
            // конвертировать строку в int и вернуть результат.
            return int.Parse(newDigits);
        }
    }
}
