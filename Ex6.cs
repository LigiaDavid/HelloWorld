﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Ex6
    {
        public void Main()
        {
            Console.WriteLine("Exercise 6:");
            Dictionary<string, int> inventory = new Dictionary<string, int>();
            inventory["apple"] = 3;
            inventory["orange"] = 5;
            inventory["banana"] = 2;

            Console.WriteLine(inventory["apple"]);
            Console.WriteLine(inventory["orange"]);
            Console.WriteLine(inventory["banana"]);
            Console.WriteLine();

        }
    }
}
