# Project Title

# Factorial Calculator (C# Console Application)

## Table of Contents
- [Description](#description)
- [How It Works](#how-it-works)
- [Code](#code)
- [How to Run](#how-to-run)
- [Example Output](#example-output)
- [Requirements](#requirements)
- [License](#license)

## Description
This is a simple C# console application that calculates the factorial of a given number. The user inputs a number, and the program computes its factorial using a loop.

## How It Works
1. The program prompts the user to enter a number.
2. It calculates the factorial of the entered number using a `for` loop.
3. The result is then displayed on the console.

## Code
```csharp
using System;

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
            Console.WriteLine("The Factorial Number is: {0}", fact);
        }
    }
}
```

## How to Run
1. Clone the repository:
   ```sh
   git clone <repository_url>
   ```
2. Open the project in Visual Studio or any C# compiler.
3. Run the program and enter a number when prompted.
4. The factorial of the entered number will be displayed.

## Example Output
```
Enter Number
5
The Factorial Number is: 120
```

## Requirements
- .NET Framework or .NET Core
- A C# compiler (Visual Studio, Visual Studio Code, or any other C# IDE)

## License
This project is open-source and available for modification and distribution.
