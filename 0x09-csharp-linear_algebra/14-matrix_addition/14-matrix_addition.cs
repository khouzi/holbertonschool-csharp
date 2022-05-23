using System;
/// <summary>
/// MatixMath: Class
/// </summary>
class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] A = new double[3,3];

        if (matrix1.Length != matrix2.Length && matrix1.Length != 3 || matrix1.Length != 2 )
                return new double[1,1]{{-1}};

                
        for(int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
                    A[i,j] = matrix1[i,j] + matrix2[i,j];
        }
        return new double[1,1]{{-1}};
    }
}
