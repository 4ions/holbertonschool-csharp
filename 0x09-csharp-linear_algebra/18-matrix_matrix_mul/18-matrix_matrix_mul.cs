using System;

///<summary> Class MatrixMath</summary>
class MatrixMath
{
    ///<summary>Method to multiply matrixs</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2){
        double[,] result = new double[matrix1.GetLength(0),matrix2.GetLength(0)];
        double dotProduct = 0;

        int i = 0;
        int j = 0;
        int column = matrix1.GetLength(1) - 1;
        if (matrix1.GetLength(1) == matrix2.GetLength(0)){

            for (i = 0; i < matrix1.GetLength(0); i++)
            {
                dotProduct = 0;
                
                for (j = 0; j < matrix2.GetLength(1); j++)
                {
                    dotProduct += matrix1[i, j] * matrix2[j, i];
                    result[i, j] = dotProduct;
                    //System.Console.WriteLine("Dot Product: "+dotProduct + " i : " + i + " j: " + j);
                    //result[i, j] += matrix1[i, j] * matrix2[j, i];
                    //System.Console.WriteLine(matrix2[j, i]);
                }
                //column--;
                //System.Console.WriteLine("Dot Product: "+dotProduct + " i: " i + " j: ");
                //j = j - 1;
                //result[j, i] = dotProduct;
            }
        }
        else {
            return new double[,] {{-1}};
        }
        return result;
    }
}
