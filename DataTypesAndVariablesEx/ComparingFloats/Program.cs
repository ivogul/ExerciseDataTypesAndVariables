using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double difference = Math.Abs(a - b);
            double eps = 0.000001;
            bool isEqual = (difference < eps);
            Console.WriteLine(isEqual);
        }
    }
}
