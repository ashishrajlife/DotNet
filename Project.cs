using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("===================");

            double num1 = GetValidNumber("Enter the first number: ");
            double num2 = GetValidNumber("Enter the second number: ");

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Square Root (First Number)");
            Console.Write("Enter your choice: ");

            int choice = GetValidChoice(1, 6);
            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        ContinuePrompt();
                        continue;
                    }
                    result = num1 / num2;
                    break;
                case 5:
                    if (num1 < 0)
                    {
                        Console.WriteLine("Error: Cannot calculate square root of a negative number.");
                        ContinuePrompt();
                        continue;
                    }
                    result = Math.Sqrt(num1);
                    break;
            }

            Console.WriteLine($"Result: {result}");
            ContinuePrompt();
        }
    }

    static double GetValidNumber(string prompt)
    {
        double number;
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out number))
                return number;
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }

    static int GetValidChoice(int min, int max)
    {
        int choice;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max)
                return choice;
            Console.WriteLine($"Invalid choice! Please enter a number between {min} and {max}.");
        }
    }

    static void ContinuePrompt()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
