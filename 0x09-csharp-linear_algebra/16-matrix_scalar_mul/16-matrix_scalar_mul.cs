using System;

///<summary> Class MatrixMath</summary>
class MatrixMath
{
    ///<summary> Method scalar multyplicate matrix</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar){
        double[,] result = new double[,]{{-1}};
        if ((matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) || (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)){
            result = new double[matrix.GetLength(0), matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++){
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
        }
        return result;
    }
}
