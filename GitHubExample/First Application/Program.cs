//Matthew Smith
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Matthew");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Smith");

            Console.Beep(1000, 250);

            Console.ReadKey();
        }
    }
}
