using System;

///<summary>Defines matrix calculation methods.</summary>
class MatrixMath
{
    ///<summary>Adds two matrices.</summary>
    ///<param name="matrix1">The first matrix.</param>
    ///<param name="matrix2">The second matrix.</param>
    ///<returns>the resulting matrix.</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        //Checks if matrixes are same size
        if (matrix1.Length - matrix2.Length != 0)
            return new double[,] { { -1 } };

        //Checks if matrix1 is 2D or 3D
        if (matrix1.GetLength(0) != 2 && matrix1.GetLength(1) != 2 && matrix1.GetLength(0) != 3 && matrix1.GetLength(1) != 3)
            return new double[,] { { -1 } };

        //Checks if matrix2 is 2D or 3D
        if (matrix2.GetLength(0) != 2 && matrix2.GetLength(1) != 2 && matrix2.GetLength(0) != 3 && matrix2.GetLength(1) != 3)
            return new double[,] { { -1 } };

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1[i, j] += matrix2[i, j];
            }
        }

        return matrix1;
    }
}
