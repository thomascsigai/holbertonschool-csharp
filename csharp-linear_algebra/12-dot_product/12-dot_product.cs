using System;
using System.Linq;

///<summary>Defines vector calculation methods.</summary>
class VectorMath
{
    ///<summary>Calculates dot product of either two 2D or two 3D vectors.</summary>
    ///<param name="vector1">The first vector.</param>
    ///<param name="vector2">The second vector.</param>
    ///<returns>The dot product.</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
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

        double result = 0;
        
        for (int i = 0; i < vector1.Count(); i++)
        {
            result += vector1[i] * vector2[i];
        }

        return result;
    }
}
