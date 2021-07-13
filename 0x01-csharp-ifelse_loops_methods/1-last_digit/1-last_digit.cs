  
using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        string info = "The last digit of";
        int lastDigit = number % 10;
        
        if (lastDigit < 6 && lastDigit != 0){
            Console.WriteLine("{0} {1} is {2} and is less that 6 and not 0", info, number, lastDigit);
        }
        else if (lastDigit > 5){
            Console.WriteLine("{0} {1} is {2} and is greater that 5", info, number, lastDigit);
        }
        else if (lastDigit == 0){
            Console.WriteLine("{0} {1} is {2} and is 0", info, number, lastDigit);
        }
    }
}