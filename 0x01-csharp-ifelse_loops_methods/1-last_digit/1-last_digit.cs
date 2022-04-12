using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int k = number % 10;
        if (k > 5)
            Console.WriteLine("the last digit of {0} and is {1} greater than 5", number, k);
        else if (k == 0)
            Console.WriteLine("the last digit of {0} is {1} and is 0", number, k);
        else 
            Console.WriteLine("the last didgit {0} is {1} and is less than 6 and not 0", number, k);
    }
}