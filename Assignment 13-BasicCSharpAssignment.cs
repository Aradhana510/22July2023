using System;

class Program
{
    static void Main()
    {
        // Task 1: Hello World
        Console.WriteLine("Hello, World!");

        // Task 2: Variables and User Input
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");

        // Task 3: Basic Arithmetic
        Console.Write("Enter the first integer: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = num1 + num2;
        int difference = num1 - num2;
        int product = num1 * num2;

        if (num2 != 0)
        {
            int division = num1 / num2;
            int modulus = num1 % num2;
            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Division: {division}, Modulus: {modulus}");
        }
        else
        {
            Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Division: Cannot divide by zero, Modulus: Cannot divide by zero");
        }

        // Task 4: Control Structures
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }

        // Task 5: Loops
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Task 6: Arrays
        int[] numbers = { 10, 20, 30, 40, 50 };
        int sumArray = 0;

        foreach (int num in numbers)
        {
            sumArray += num;
        }

        double average = (double)sumArray / numbers.Length;

        Console.WriteLine($"Sum: {sumArray}, Average: {average}");

        // Task 7: Methods
        Console.Write("Enter a positive integer: ");
        int numFactorial = int.Parse(Console.ReadLine());

        long factorial = CalculateFactorial(numFactorial);

        Console.WriteLine($"Factorial of {numFactorial} is {factorial}");

        // Task 8: Exception Handling
        int age;

        while (true)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out age))
            {
                if (age < 0)
                {
                    Console.WriteLine("Age cannot be negative. Please enter a valid age.");
                }
                else if (age < 18)
                {
                    Console.WriteLine("You are a minor.");
                }
                else if (age >= 18 && age <= 65)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior.");
                }

                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }

    static long CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else
            return n * CalculateFactorial(n - 1);
    }
}
