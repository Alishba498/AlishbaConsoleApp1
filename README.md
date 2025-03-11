
# AlishbaConsoleApp1 - Factorial Calculator

## Description
This is a simple **C# console application** that calculates the factorial of a given number. The program ensures user-friendly input validation and improved code structure.

## Features
 Calculates the factorial of a given number.
 Handles non-integer inputs and prevents crashes.
 Ensures only non-negative integers are accepted.
 Uses a separate method for better code readability.

## How to Run
1. **Clone the Repository**
   ```bash
   git clone https://github.com/your-username/AlishbaConsoleApp1.git
   cd AlishbaConsoleApp1
   ```

2. **Compile and Run the Code**
   - Open the project in **Visual Studio** or **VS Code**.
   - Run the following command in the terminal:
     ```bash
     dotnet run
     ```

3. **Enter a Number**
   - The program will prompt you to enter a positive integer.
   - It will calculate and display the factorial of the given number.

## Code
```csharp
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
```

## Modifications Made
1. **Input Validation**: Ensures the user enters a valid number.
2. **Error Handling**: Prevents crashes if non-numeric input is given.
3. **Separate Method (`CalculateFactorial`)**: Improves code readability and modularity.
4. **Supports Large Factorial Values**: Uses `long` instead of `int` for large numbers.

## Contributions
Feel free to contribute! Fork the repo, make changes, and submit a pull request.

## License
This project is open-source and available under the **MIT License**.

