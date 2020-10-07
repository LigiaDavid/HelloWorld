using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Ex10
    {
        public void Main()
        {
            Console.WriteLine("Exercise 10:");
            int x = 2;
            int y = 2;
            int a = Foo(x, y);
            Console.WriteLine(a);
            Console.WriteLine();
        }

        public static int Foo(int x, int y)
        {
            return x / y;
        }
    }
}

