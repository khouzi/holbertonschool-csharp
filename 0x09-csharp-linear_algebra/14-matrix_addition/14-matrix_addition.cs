using System;
/// <summary>
/// MatixMath: Class
/// </summary>
class MatrixMath
{
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] A = new double[2,2];
		double[,] B = new double[3,3];
		double[,] C = new double[2,2]{{-1,-1}, {-1,-1}};


        if (matrix1.Length != matrix2.Length)
                return new double[1,1]{{-1}};

        if (matrix1.Length != 3 || matrix1.Length != 2)
                return new double[1,1]{{-1}};

        if (matrix1.Length == 2)
        {
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    A[i,j] = matrix1[i,j] + matrix2[i,j];

            return A;
        }

        else if (matrix1.Length == 3)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    B[i,j] = matrix1[i,j] + matrix2[i,j];
            return B;
        }

        else
            return C;
    }
}
