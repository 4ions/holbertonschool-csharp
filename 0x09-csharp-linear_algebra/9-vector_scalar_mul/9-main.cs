using System;

class Program{
    static void Main(string[] args)
    {
        double[] vector = {0, -16, 31};
        double scalar = 4;
        double[] result = new double[3];
        result = VectorMath.Multiply(vector, scalar);
        foreach (double i in result){
            System.Console.Write(i);

        }
    }
}