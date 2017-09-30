using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            //string str2 = "0x37";
            //string str3 = "0x10";

            decimal hex1 = Convert.ToInt32(str1, 16);
            //decimal hex2 = Convert.ToInt32(str2, 16);
            //decimal hex3 = Convert.ToInt32(str3, 16);

            Console.WriteLine(hex1);
            //Console.WriteLine(hex2);
            //Console.WriteLine(hex3);
        }
    }
}
