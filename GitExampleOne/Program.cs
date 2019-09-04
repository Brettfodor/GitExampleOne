using System;

namespace GitExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Brett";

            string lastName = "Fodor";
            
            int age = 29;

            int puttingOnSomeYears = 40;

            int oldAge = age + puttingOnSomeYears;

            Console.WriteLine(firstName + " " + lastName);

            Console.WriteLine("I am " + age + " years old");

            Console.WriteLine("I'm really glad I'm not " + oldAge + " years old");
        }
    }
}
