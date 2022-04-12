using System;


    class Line
    {
        public static void PrintDiagonal(int length)
        {
	        int i, s;

	        if (length > 0)
	        {
		    for (i = 0; i < length; i++)
		        {
			    for (s = 0; s < i; s++)
				    Console.Write(' ');
			    Console.Write('\\');

			    if (i == length - 1)
				continue;

			    Console.Write('\n');
		        }
	        }

	            Console.Write('\n');
        }
    }
