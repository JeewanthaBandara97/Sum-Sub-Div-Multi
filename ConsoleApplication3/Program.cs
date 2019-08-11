using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Number 1:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Number 2:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("+ is" + (num1 + num2));
            Console.WriteLine("- is" + (num1 - num2));
            Console.WriteLine("* is" + (num1 * num2));
            Console.WriteLine("/ is" + (num1 / num2));
            
            Console.WriteLine("/ is" + (double)(num1) / (double)(num2));

            Console.ReadKey();
        }
    }
}
