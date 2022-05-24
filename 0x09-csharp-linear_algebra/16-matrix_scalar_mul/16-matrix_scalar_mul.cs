using System;
/// <summary>
/// class MatrixMath
/// </summary>

class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.Length != 2 || matrix.Length != 3)
        {
            return (new Double[,] { { -1 } });
        }

        double[,] A = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                A[i, j] = matrix[i, j] * scalar;
            }
        }
        return A;
    }
}