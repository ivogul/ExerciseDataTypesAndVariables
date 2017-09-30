using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            bool bl1 = Convert.ToBoolean(str1);
            if (bl1)
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }
        }
    }
}
