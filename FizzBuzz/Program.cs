using System;

namespace FizzBuzz
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            for (int number = 1; number < 101; number++)
            {
                string output = "";
                if (number % 3 == 0)
                {
                    output += "Fizz";
                }

                if (number % 5 == 0)
                {
                    output += "Buzz";
                }

                if (output == "")
                {
                    Console.WriteLine(number);
                }
                else
                {
                    Console.WriteLine(output);
                }
            }
        }
    }
}