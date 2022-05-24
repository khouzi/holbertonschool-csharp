using System;

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] A = new double[2,2];
		double[,] B = new double[3,3];
		double[,] C = new double[2,2]{{-1,-1}, {-1,-1}};

         if (matrix.Length == 2)
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    A[i,j] = matrix[i,j] * scalar;

            return A;
        }

        else if (matrix.Length == 3)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    B[i,j] = matrix[i,j] * scalar;
            return B;
        }

        else
            return C;
    }
}