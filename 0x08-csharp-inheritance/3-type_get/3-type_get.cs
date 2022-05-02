using System;
using System.Collections.Generic;
using System.Reflection;

    class Obj
    {
        public static void Print(object myObj)
        {
            string string_type = myObj.GetType().Name;
            Type type = myObj.GetType();
            Console.WriteLine("{0} Properties:", string_type);
            foreach (var element in type.GetProperties())
                Console.WriteLine(element.Name);
            Console.WriteLine("{0} Methods:", string_type);
            foreach (var element2 in type.GetMethods())
                Console.WriteLine(element2.Name);
        }
    }

