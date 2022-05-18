using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] A = new double[2];
		double[] B = new double[3];
		double[] C = new double[]{-	1};

        if ( vector.Length == 2)
        {
            A[0] = vector[0] * scalar;
            A[1] = vector[1] * scalar;
            return A;
        }
        else if ( vector.Length == 3)
        {
            B[0] = vector[0] * scalar;
            B[1] = vector[1] * scalar;
            return B;
        }

        else
            return C;
    }    
}
