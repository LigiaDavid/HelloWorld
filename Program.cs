using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1: Print "Hello, World!" to the console.
            HelloWorld.Ex1 HelloWorld = new Ex1();
            HelloWorld.Hello();

              /*Exercise 2: Define three variables:
              A string named productName equal to TV.
              An integer named productYear equal to 2012.
              A float named productPrice equal to 279.99f. */
            HelloWorld.Ex2 Var = new Ex2();
            Var.Variables();

              //Exercise 3: Construct an if statement that checks if the number guess is equal to 500. If that is the case, use Console.WriteLine to display "Success!".
            HelloWorld.Ex3 Conditionals = new Ex3();
            Conditionals.Main();

            //Exercise 4: Define an array called fruits that holds the following strings: "apple", "banana", and "orange".
            HelloWorld.Ex4 Arrays = new Ex4();
            Arrays.Main();

            //Exercise 5: Construct a list of the first 5 prime numbers (2, 3, 5, 7, 11) called primeNumbers.
            HelloWorld.Ex5 Lists = new Ex5();
            Lists.Main();

            /* Exercise 6: Create a new dictionary called inventory that holds 3 names of fruits, and the amount they are in stock.
            Here is the inventory specification:
            3 of type apple
            5 of type orange
            2 of type banana */
            HelloWorld.Ex6 Dictionaries = new Ex6();
            Dictionaries.Main();

            /* Exercise 7: Use string formatting to format the variables firstName, lastName and age to form the following sentence into the string sentence:
            John Doe is 27 years old.*/
            HelloWorld.Ex7 Strings = new Ex7();
            Strings.Main();

            // Exercise 8: Print the value of variable X to the screen N number of times
            HelloWorld.Ex8 ForLoops = new Ex8();
            ForLoops.Main();

            // Exercise 9: Print X to the console N time using a while loop
            HelloWorld.Ex9 WhileLoops = new Ex9();
            WhileLoops.Main();

            // Exercise 10: Write a method that divides two numbers (provided as parameters). 
            HelloWorld.Ex10 Methods = new Ex10();
            Methods.Main();
            
            // Exercise 11: Make a class car with the properties numTires = 4, year = 2000, and runs = true, and create three instances of it: car1, car2, and car3.
            HelloWorld.car Classes = new car();
            HelloWorld.MainClass car = new MainClass();
            car.Main();

            // Exercise 12:Make a class Vehicle with the properties string Type, int NumTires, int Year, and bool Runs, and create:
            // A car: Type = car with NumTires = 4 from Year = 2000 which Runs = true An oldcar: Type = car with NumTires = 4 from Year = 1980 which Runs = false A bike: Type = bike with NumTires = 2 from Year = 2017 which Runs = true
            HelloWorld.Vehicle2 ClassProperties2 = new Vehicle2();
            ClassProperties2.Main();

            Console.ReadLine();
        }
    }
}
