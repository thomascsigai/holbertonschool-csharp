using System;
using System.Linq;

///<summary>Defines vector calculation methods.</summary>
class VectorMath
{
    ///<summary>Calculates and returns the length of a given vector.</summary>
    ///<param name="vector">The vector.</param>
    ///<returns>The length of the vector rounded to the nearest hundredth.</returns>
    public static double Magnitude(double[] vector)
    {
        if (vector.Count() != 2 || vector.Count() != 3)
            return -1;

        double squaredSum = 0;
        
        foreach (double number in vector)
        {
            squaredSum += number * number;
        }
        
        return Math.Round(Math.Sqrt(squaredSum), 2);
    }
}
