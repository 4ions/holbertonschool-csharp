using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string space = " ";
            
            for (int i = 1; i <= 100; i++)
            {
                if (i == 100)
                    space = "";
                
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write($"FizzBuzz{space}");
                }
                else if (i % 3 == 0){
                    Console.Write($"Fizz{space}");
                }
                else if (i % 5 == 0){
                    Console.Write($"Buzz{space}");
                }
                else {
                    Console.Write($"{i}{space}");
                }
            }
        }
    }
}
