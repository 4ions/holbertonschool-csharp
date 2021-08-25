using System;
using System.Collections.Generic;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        double[] vector = {7, -3, -9};

        double result = VectorMath.Magnitude(vector);
        System.Console.WriteLine(result);
    }
}