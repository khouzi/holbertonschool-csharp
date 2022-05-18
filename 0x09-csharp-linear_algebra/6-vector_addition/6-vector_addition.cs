using System;


class VectorMath
{
	public static double[] Add(double[] vector1, double[] vector2)
	{
		double[] A = new double[2];
		double[] B = new double[3];
		double[] C = new double[]{-	1};

		if (vector1.Length == 2 && vector1.Length == vector2.Length )
		{
			A[0] = (vector1[0] + vector2[0]);
			A[1] = (vector1[1] + vector2[1]);
			return A;
			
		}

		if (vector1.Length == 3 && vector1.Length == vector2.Length )
		{
			B[0] = (vector1[0] + vector2[0]);
			B[1] = (vector1[1] + vector2[1]);
			B[2] = (vector1[2] + vector2[2]);		
			return B;
		}

		else
			return C;

	}
}

