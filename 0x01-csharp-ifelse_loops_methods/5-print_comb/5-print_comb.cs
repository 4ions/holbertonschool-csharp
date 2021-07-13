using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            for (int i = 1; i <= 99; i++)
            {
                number = i / 10;
                if (i < 99)
                    Console.Write($"{number}{i % 10}, ");

                if (i == 99){
                    Console.Write($"{i}\n");
                }
            }
        }
    }
}
