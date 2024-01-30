using System;

class MatrixMath
{
    public static double Determinant(double[,] matrix)
    {
        //Checks if matrixes are same size
        if (matrix1.Length - matrix2.Length != 0)
            return new double[,] { { -1 } };

        if (matrix1.Length != 4 && matrix2.Length != 9)
            return new double[,] { { -1 } };

        //Checks if matrix1 is 2D or 3D
        if (matrix.GetLength(0) != 2 && matrix.GetLength(1) != 2 && matrix.GetLength(0) != 3 && matrix.GetLength(1) != 3)
            return new double[,] { { -1 } };

        if (matrix.Length == 4)
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        else
            return matrix[0, 0] * matrix[1, 1] * matrix[2, 2] +
           matrix[0, 1] * matrix[1, 2] * matrix[2, 0] +
           matrix[0, 2] * matrix[1, 0] * matrix[2, 1] -
           matrix[0, 2] * matrix[1, 1] * matrix[2, 0] -
           matrix[0, 1] * matrix[1, 0] * matrix[2, 2] -
           matrix[0, 0] * matrix[1, 2] * matrix[2, 1];
    }
}
