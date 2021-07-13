using System;

namespace _11_print_diagonal
{
    class Line
    {
        public static void PrintDiagonal(int length){
            if (length == 0 || length < 0)
            {
                Console.WriteLine();
                return;
            }

            string space = "";
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{space}\\");
                space += " ";
            }
            Console.WriteLine();
        }
    }
}
