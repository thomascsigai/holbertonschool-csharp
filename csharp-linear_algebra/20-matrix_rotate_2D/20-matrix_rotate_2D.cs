using System;

class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Vérifier si la matrice est carrée
        if (rows != cols)
        {
            return new double[,] { { -1 } };
        }

        if (matrix.Length != 4)
            return new double[,] { { -1 } };

        double[,] rotatedMatrix = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Appliquer la rotation à chaque élément
                rotatedMatrix[i, j] = Math.Round(matrix[i, j] * Math.Cos(angle) - matrix[j, i] * Math.Sin(angle), 2);
            }
        }

        return rotatedMatrix;
    }
}
