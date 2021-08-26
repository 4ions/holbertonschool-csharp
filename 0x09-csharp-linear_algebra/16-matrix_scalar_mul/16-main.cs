using System;

class Program{
    static void Main(string[] args){
        double[,] matrix = new double[,] {{-13, 10, 8}, {2, 0, 14}, {-4, -5, 2}};
        double scalar = 4f;

        double[,] result = new double[3,3];
        result = MatrixMath.MultiplyScalar(matrix, scalar);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                System.Console.Write(result[i, j]);
            }
            System.Console.WriteLine();
        }
    }
}