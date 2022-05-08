using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            int width = int.Parse(Console.ReadLine());
            int Area = length * width;
            int peri = (length + width) * 2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The area of rectangle is " + Area);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The perimeter of the rectangle is " + peri);
            Console.ReadKey();
        }
    }
}
