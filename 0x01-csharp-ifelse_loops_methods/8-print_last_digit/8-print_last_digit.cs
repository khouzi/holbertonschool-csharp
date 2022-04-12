using System;

namespace _8_print_last_digit
{
    class Number
    {
        public static int PrintLastDigit(int number)
        {
            int last_digit;

            last_digit = number % 10;
            Console.Write(last_digit);
            return(last_digit);
        }
    }
}
