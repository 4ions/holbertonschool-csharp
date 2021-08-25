using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        double[] vector1 = new double[3] {7, -3, -9};
        double[] vector2 = new double[3] {7, -3, -9};

        double[] result = new double[3];
        result = VectorMath.Add(vector1, vector2);
        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine(result[i]);
        }

    }
}