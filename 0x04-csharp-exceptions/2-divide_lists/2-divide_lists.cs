using System;
using System.Collections.Generic;


    class List
    {
        public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
        {
            List<int> result_list = new List<int>();
            for (int i = 0; i < listLength; i++)
            {
                try
                {
                    result_list.Add(list1[i] / list2[i]);
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide be zero");
                    result_list.Add(0);
                }
                catch(Exception)
                {
                    Console.WriteLine("Out of range");
                }
            }
            return result_list;
        }
    }


