using System;

namespace GitExampleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Brett";

            string lastName = "Fodor";

            string sweetness = "Not Brett";
            
            int age = 29;

            int puttingOnSomeYears = 40;

            int oldAge = age + puttingOnSomeYears;

            Console.WriteLine(firstName + " " + lastName);

            Console.WriteLine("I am " + age + " years old");

            Console.WriteLine("I'm really glad I'm not " + oldAge + " years old");

            Console.WriteLine("Who is the Sweetness? " + sweetness);
        }
    }
}
