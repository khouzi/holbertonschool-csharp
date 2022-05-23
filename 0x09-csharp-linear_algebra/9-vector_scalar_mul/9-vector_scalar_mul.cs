using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length != 3 && vector.Length != 2)
                return new Double[1]{-1};
            double[] A = new Double[3];
            for(int i = 0; i < vector.Length; i++)
                   A[i] = scalar * vector[i];
            return A;
    }    
}
