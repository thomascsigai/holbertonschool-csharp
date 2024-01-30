﻿using System;
using System.Linq;

class VectorMath
{
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Count() != 3 || vector2.Count() != 3)
            return new double[] {-1};

        double[] crossProduct = new double[3];

        crossProduct[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        crossProduct[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        crossProduct[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return crossProduct;
    }
}
