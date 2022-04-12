using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for(i = 0; i <=9; i++)
            {
                for(j = 0; j <= 8; j++)
                {
                    if (i < j)
                    {
                        Console.Write(i);
                        Console.Write("{0}, ",j);
                    }
                }
            }
            Console.WriteLine("79, 89");
        }
    }
}
