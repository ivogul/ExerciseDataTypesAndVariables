﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before: \r\na = {a}\r\nb = {b}");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After: \r\na = {a}\r\nb = {b}");
        }
    }
}
