using System;

///<summary> Class of VectorMath</summary>
class VectorMath
{
    ///<summary> method to calculate the dot product of two vectors</summary>
    public static double DotProduct(double[] vector1, double[] vector2){
        double result = 0;

        if (vector1.Length == vector2.Length && (vector2.Length == 3 || vector2.Length == 2)){
            for (int i = 0; i < vector1.Length; i++){
                result += vector1[i] * vector2[i];
            }
        }
        else {
            result = -1f;
        }

        return result;
    }
}
