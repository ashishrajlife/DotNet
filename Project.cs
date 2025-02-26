using System;

class BasicCalculator
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("===================");

        double firstNumber = GetNumber("Enter the first number: ");
        double secondNumber = GetNumber("Enter the second number: ");

        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Square Root (First Number)");
        Console.Write("Enter your choice: ");

        int operation = GetChoice(1, 5);
        double output = 0;

        switch (operation)
        {
            case 1:
                output = firstNumber + secondNumber;
                break;
            case 2:
                output = firstNumber - secondNumber;
                break;
            case 3:
                output = firstNumber * secondNumber;
                break;
            case 4:
                if (secondNumber == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                output = firstNumber / secondNumber;
                break;
            case 5:
                if (firstNumber < 0)
                {
                    Console.WriteLine("Error: Cannot calculate square root of a negative number.");
                    return;
                }
                output = Math.Sqrt(firstNumber);
                break;
        }

        Console.WriteLine($"Result: {output}");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static double GetNumber(string message)
    {
        double value;
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out value))
                return value;
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }

    static int GetChoice(int min, int max)
    {
        int selection;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out selection) && selection >= min && selection <= max)
                return selection;
            Console.WriteLine($"Invalid choice! Please enter a number between {min} and {max}.");
        }
    }
}
