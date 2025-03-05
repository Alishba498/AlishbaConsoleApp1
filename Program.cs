using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlishbaConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("Enter Number");
            int number = int.Parse(Console.ReadLine());
            for(int i = number; i >= 1; i--) 
            {
                fact = fact * i;
            }
            Console.WriteLine("The Factorial Number is:(0)", fact);
        }
    }
}
