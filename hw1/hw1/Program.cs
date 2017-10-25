using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor concol1 = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            ConsoleColor concol = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World, Yulia!");
            Console.ReadLine();
        }
    }
}
