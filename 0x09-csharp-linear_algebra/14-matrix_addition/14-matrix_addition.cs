using System;

///<summary> Class MatrixMath</summary>
class MatrixMath
{
    ///<summary> Method to add two matrixs</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] result = new double[matrix1.GetLength(0),matrix1.GetLength(0)];
        if (matrix1.GetLength(1) == matrix2.GetLength(1) && matrix1.GetLength(0) == matrix2.GetLength(0) && (matrix2.GetLength(0) == 3 || matrix1.GetLength(0) == 2)){
            for (int i = 0; i < matrix1.GetLength(0); i++){
                for (int j = 0; j < matrix1.GetLength(0); j++)
                {
                    result[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }
        }
        else {
            double[,] error = new double[,] {{-1}};
            return error;
        }

        return result;
    }
}
