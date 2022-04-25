using System;
using System.Collections.Generic;

    class List
    {
        public static int SafePrint(List<int> myList, int n)
        {
            int  counter = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(myList[i]);
                    counter++;
                }
            }
            catch
             {
                return counter;
             }
             return counter;
        }
    }

