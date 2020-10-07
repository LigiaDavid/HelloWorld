using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Ex7
    {
        public void Main()
        {
            Console.WriteLine("Exercise 7:");
            string firstName = "John";
            string lastName = "Doe";
            int age = 27;

            string sentence = String.Format("{0} {1} is {2} years old.",
                firstName, lastName, age);

            Console.WriteLine(sentence);
            Console.WriteLine();
        }
    }
}
