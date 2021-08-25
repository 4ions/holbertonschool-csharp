﻿using System;

/// <summary> Class VectorMath </summary>
class VectorMath
{
    /// <summary> method that calculates 2d and 3d vector's and returns its magnitud </summary>
    public static double Magnitude(double[] vector){
        int size = vector.Length;
        double result = -1;
        if (size == 2 || size == 3){
            foreach (int i in vector)
            {
                result += Math.Pow(i, 2);
            }

            result = Math.Sqrt(result);
        }
        

        return result;
    }
}

