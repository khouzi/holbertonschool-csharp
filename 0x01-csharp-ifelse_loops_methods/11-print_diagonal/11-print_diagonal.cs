using System;


    class Line
    {
        public static void PrintDiagonal(int igth)
        {
	        int i, s;

	        if (igth > 0)
	        {
		    for (i = 0; i < igth; i++)
		        {
			    for (s = 0; s < i; s++)
				    Console.Write(' ');
			    Console.Write('\\');

			    if (i == igth - 1)
				continue;

			    Console.Write('\n');
		        }
	        }

	            Console.Write('\n');
        }
    }
