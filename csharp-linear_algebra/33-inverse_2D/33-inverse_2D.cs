using System;

class Program
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            throw new ArgumentException("La matrix doit être 2x2.");
        }

        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[1, 0];
        double d = matrix[1, 1];

        double determinant = a * d - b * c;

        if (determinant == 0)
        {
            return [-1];
        }

        double[,] matrixInverse = new double[2, 2];
        matrixInverse[0, 0] = d / determinant;
        matrixInverse[0, 1] = -b / determinant;
        matrixInverse[1, 0] = -c / determinant;
        matrixInverse[1, 1] = a / determinant;

        return matrixInverse;
    }
}
