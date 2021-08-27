using System;

class Program{
    static void Main(string[] args){
        double[,] matrix1 = new double[,] {{2, 3}, {-1, 0}};
        double[,] matrix2 = new double[,] {{1, 7}, {-8, -2}};

        double[,] result = new double[2,2];
        result = MatrixMath.Multiply(matrix1, matrix2);
        for (int i = 0; i < result.GetLength(0); i++){
            for (int j = 0; j < result.GetLength(1); j++){
                System.Console.Write(result[i, j]+ " ");
            }
            System.Console.WriteLine();
        }

    }
}