using System;

///<summary>Algebraic operations on vectors.</summary>
class VectorMath
{
    ///<summary>Adds two vectors.</summary>
    public static double[] Add(double[] vector1, double[] vector2){
        double[] result = new double[1] {-1};

        if (vector1.Length == vector2.Length && (vector1.Length == 2 || vector2.Length == 3)){
            result = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++) {
                result[i] = vector1[i] + vector2[i];
            }

            return result;
        }

        return result;
    }
}
