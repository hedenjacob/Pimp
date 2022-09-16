using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pimp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor myColor = ConsoleColor.Green;
            Console.ForegroundColor = myColor;
            Console.WriteLine("The foreground color is {0}.", myColor);
            Console.Beep();
            Console.Title = "DJ MOKAI";           
        }
    }
}
