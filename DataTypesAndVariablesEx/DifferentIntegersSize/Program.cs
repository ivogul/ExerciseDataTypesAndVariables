using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            long value;
            if (long.TryParse(n, out value))
            {
                Console.WriteLine($"{n} can fit in:");
                if (value <= sbyte.MaxValue && value >= sbyte.MinValue) Console.WriteLine("* sbyte");
                if (value <= byte.MaxValue && value >= byte.MinValue) Console.WriteLine("* byte");
                if (value <= short.MaxValue && value >= short.MinValue) Console.WriteLine("* short");
                if (value <= ushort.MaxValue && value >= ushort.MinValue) Console.WriteLine("* ushort");
                if (value <= int.MaxValue && value >= int.MinValue) Console.WriteLine("* int");
                if (value <= uint.MaxValue && value >= uint.MinValue) Console.WriteLine("* uint");
                if (value <= long.MaxValue && value >= long.MinValue) Console.WriteLine("* long");
            }
            else Console.WriteLine($"{n} can't fit in any type");
        }
    }
}
