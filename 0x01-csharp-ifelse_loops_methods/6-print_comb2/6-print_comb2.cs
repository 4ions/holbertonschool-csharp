using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 89; i++)
            {
                int left = i / 10;
                int right = i % 10;

                if (left != right && left < right && i < 89){
                    Console.Write($"{left}{right}, ");
                }
                else if (i == 89){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
