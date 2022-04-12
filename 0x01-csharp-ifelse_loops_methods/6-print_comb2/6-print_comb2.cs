using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for(i = 0; i <9; i++)
            {
                for(j = 0; j <= 9; j++)
                {
                    if (i < j)
                    {
                        if( i < 8 || j < 9)
                        {
                            Console.Write($"{i}{j}, ");
                        }
                        else
                            Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }
    }
}
