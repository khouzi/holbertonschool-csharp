using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                    Console.Write("Fizz ");
                else if  (i % 5 == 0)
                    Console.Write("Buzz ");
                else if (i % 5 == 0 && i % 3 == 3)
                    Console.Write("FizzBuzz ");
                else
                    Console.Write($"{i} ");
            }
            Console.WriteLine("Buzz");
        }
    }
}