using System;

class Array
{
    public static void Reverse(int[] array)
    {   if (array == null)
            {
                Console.WriteLine();
                return;
            }


        if (array.Length > 0)
        {
             for (int i = array.Length - 1; i > 0 ; i--){
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(array[0]);
        }
        else
            Console.WriteLine();


       
    }


}