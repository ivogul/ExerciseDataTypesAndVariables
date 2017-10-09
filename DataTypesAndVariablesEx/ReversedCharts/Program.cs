using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = Convert.ToChar(Console.ReadLine());
            char second = Convert.ToChar(Console.ReadLine());
            char third = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"{third}{second}{first}");
        }
    }
}
