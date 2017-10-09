using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";//Console.ReadLine();
            string lastName = "Jonson";//Console.ReadLine();
            int age = 27;//int.Parse(Console.ReadLine());
            char gender = 'f'; //Convert.ToChar(Console.ReadLine());
            long personalID = 8306112507; // int.Parse(Console.ReadLine());
            int empoyeeID = 27563571;//int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {empoyeeID}");
        }
    }
}
