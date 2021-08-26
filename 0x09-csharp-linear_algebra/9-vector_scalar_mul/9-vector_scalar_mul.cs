using System;

///<summary> Class VectorMath of vectors</summary>
class VectorMath
{
    ///<summary>Method of multiply scalar for a vector.</summary>
    public static double[] Multiply(double[] vector, double scalar){
        double[] result = new double[1] {-1};

        if (vector.Length == 2 || vector.Length == 3)
        {
            result = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                result[i] = vector[i] * scalar;
            }
        }

        return result;
    }
}
