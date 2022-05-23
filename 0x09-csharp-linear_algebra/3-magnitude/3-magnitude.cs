using System;
/// <summary>
/// VectorMath: Class
/// </summary>

    class VectorMath
    {
        public static double Magnitude(double[] vector)
        {
            double x = 0;

            if (vector.Length !=3 && vector.Length !=2)
                return -1;

            else if (vector.Length == 2)  
                x = Math.Round(Math.Sqrt((Math.Pow(vector[0], 2) + (Math.Pow(vector[1], 2)))), 2);

            else if (vector.Length == 3)
                x = Math.Round(Math.Sqrt((Math.Pow(vector[0], 2) + (Math.Pow(vector[1], 2)) + (Math.Pow(vector[2], 2)))), 2);

            return x ;      
        }
    }
