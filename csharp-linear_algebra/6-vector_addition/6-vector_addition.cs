using System;
using System.Linq;

///<summary>Defines vector calculation methods.</summary>
class VectorMath
{
    ///<summary>Adds two vectors and returns the resulting vector.</summary>
    ///<param name="vector1">The first vector.</param>
    ///<param name="vector2">The second vector.</param>
    ///<returns>The resulting vector.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        //Checks if vectors are same size
        if (vector1.Count() - vector2.Count() != 0)
            return new double[] {-1, -1};

        //Checks if vector1 is 2D or 3D
        if (vector1.Count() != 2 && vector2.Count() != 3)
            return new double[] {-1, -1};

        //Checks if vector2 is 2D or 3D
        if (vector2.Count() != 2 && vector2.Count() != 3)
            return new double[] {-1, -1};

        double[] vectorSum = new double[vector1.Count()];

        for (int i = 0; i < vector1.Count(); i++)
        {
            vectorSum[i] = vector1[i] + vector2[i];
        }

        return vectorSum;
    }
}
