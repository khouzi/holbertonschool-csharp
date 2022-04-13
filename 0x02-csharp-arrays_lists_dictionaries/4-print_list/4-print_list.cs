using System;
using System.Collections.Generic;


class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            System.Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> numbers = new List<int>();
        if ( size > 0)
        {    
            int i = 0;
        
            for (; i < size - 1; i++)
            {
                numbers.Add(i);
                System.Console.Write("{0} ",i);
            }

            numbers.Add(i);
            System.Console.WriteLine(i);
        }
        else
            System.Console.WriteLine();
        return numbers;
    }
}