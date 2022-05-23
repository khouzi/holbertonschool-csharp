using System;
/// <summary>
/// VectorMath: Class
/// </summary>

    class VectorMath
    {
        public static double Magnitude(double[] vector)
        {
        /// <summary>
        /// Calculates a given vector magnitude
        /// </summary>
        /// <param name="vector">the vector</param>
        /// <returns>Magntiude of the vector</returns>
            if (vector.Length !=3 && vector.Length !=2)
                return -1;

            else if (vector.Length == 2)  
                return (Math.Round(Math.Sqrt((Math.Pow(vector[0], 2) + (Math.Pow(vector[1], 2))))));

            else if (vector.Length == 3)
                return (Math.Round(Math.Sqrt((Math.Pow(vector[0], 2) + (Math.Pow(vector[1], 2)) + (Math.Pow(vector[2], 2)))), 2));
            
            
            
        }
    }
