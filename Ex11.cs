using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class car
    {
        public int numTires = 4;
        public int year = 2000;
        public bool runs = true;
    }
    public class MainClass
    {
        public void Main()
        {
            Console.WriteLine("Exercise 11:");
            car car1 = new car();
            car car2 = new car();
            car car3 = new car();
            // Test code
            Console.WriteLine(car1.numTires);
            Console.WriteLine(car2.year);
            Console.WriteLine(car3.runs);
            Console.WriteLine();
        }
    }
}
