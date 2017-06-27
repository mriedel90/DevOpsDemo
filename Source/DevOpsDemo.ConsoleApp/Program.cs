using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            var first = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine("Enter second number:");
            var second = int.Parse(Console.ReadLine() ?? "");
            Console.WriteLine($"Sum is: {Worker.SimpleAdd(first, second)}");
            Console.ReadLine();
        }
    }
}
