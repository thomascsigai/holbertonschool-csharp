using System;

namespace MyMath
{
    ///<summary>Defines matrix operations implementations.</summary>
    public class Matrix
    {
        ///<summary>Divides all elements of a matrix.</summary>
        ///<param name="matrix">The matrix.</param>
        ///<param name="num">The number to divide by.</param>
        ///<returns>The resulted matrix</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {

            if (matrix == null)
                return null;
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    try
                    {
                        matrix[i, j] /= num;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Num cannot be 0");
                        return null;
                    }
                    
                }
            }

            return matrix;
        }
    }
}
