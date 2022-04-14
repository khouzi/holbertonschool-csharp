using System;
using System.Collections.Generic;

    class List
    {
        public static int Sum(List<int> myList)
        {
            HashSet<int> nelement = new HashSet<int>();
            foreach(int element in myList)
            {
                nelement.Add(element);
            }
            int a = 0;
            foreach(int item in nelement)
                {
                    a += item;
                }
            return a;

        }
    }

