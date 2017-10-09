using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //int value = 0;
            //int counter = 0;
            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    if (int.TryParse(input, out value))
            //    {
            //        counter++;
            //    }
            //    else
            //    {
            //        Console.WriteLine(counter);
            //        break;
            //    }
            //}
            int value = 0;
            string symbol = Console.ReadLine();
            if (int.TryParse(symbol, out value)) Console.WriteLine("digit");
            else if (symbol == "a" || symbol == "e" || symbol == "i" || symbol == "o" || symbol == "u" || symbol == "A" || symbol == "E" || symbol == "I" || symbol == "O" || symbol == "U") Console.WriteLine("vowel");
            else Console.WriteLine("other");
        }
    }
}
