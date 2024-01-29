using System;
using System.Linq;

///<summary>Defines vector calculation methods.</summary>
class VectorMath
{
    ///<summary>Multiplies a vector and a scalar.</summary>
    ///<param name="vector">The vector.</param>
    ///<param name="scalar">The scalar.</param>
    ///<returns>The resulting vector.</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Count() != 2 && vector.Count() != 3)
            return new double[] {-1, -1};

        for (int i = 0; i < vector.Count(); i++)
        {
            vector[i] *= scalar;
        }

        return vector;
    }
}
