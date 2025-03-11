using System;

namespace AlishbaConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer:");

            
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"The Factorial of {number} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a non-negative integer.");
            }
        }

        
        static long CalculateFactorial(int num)
        {
            long fact = 1;
            for (int i = 2; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
