using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Ex5
    {
        public void Main()
        {
            Console.WriteLine("Exercise 5:");
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);

            Console.WriteLine(primeNumbers.Count);
            Console.WriteLine(primeNumbers[0]);
            Console.WriteLine(primeNumbers[1]);
            Console.WriteLine(primeNumbers[2]);
            Console.WriteLine(primeNumbers[3]);
            Console.WriteLine(primeNumbers[4]);
            Console.WriteLine();

        }
    }
}
