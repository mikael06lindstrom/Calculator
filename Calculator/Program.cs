using System;

namespace Calculator
{
    /// <summary>
    /// The class for this program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The name of this program
        /// </summary>
        const string ProgramName = "The Calculator 2000";

        /// <summary>
        /// The start point of this program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Welcome the user to this program
            Console.WriteLine($"Welcome to {ProgramName}!");

            // Make a pause in the program
            Console.ReadKey();
        }

        /// <summary>
        /// Show a header in console window
        /// </summary>
        /// <param name="title">The text in the header</param>
        static void ShowAHeader(string title) => Console.WriteLine($"********** {title} **********");
        /// <summary>
        /// Collecting of some integer values
        /// </summary>
        /// <returns>A array of integer values</returns>
        static int[] GetSomeInteger()
        {
            // Variables for collect some integer values
            string numbers;
            int[] result;

            // Ask the user for some integer values
            Console.WriteLine("Write some numbers and split them by coma: ");
            numbers = Console.ReadLine();

            // Convert a string value into a array of integer values
            result = Array.ConvertAll(numbers.Split(","), int.Parse);
            return result;
        }
        
        /// <summary>
        /// Calculate the sum of some integer values and show result in console window
        /// </summary>
        static void Addition()
        {
            // Show a header for this addition function
            ShowAHeader("Addition");

            // Variables for calculation of the sum
            int[] numbers = GetSomeInteger();
            int result = 0;

            // Calculation of the sum and show the result in console window
            Console.Write("The sum of ");
            for(int i = 0; i < numbers.Length; i++) 
            {
                // Add value to result
                result += numbers[i];

                // Show the number that added to result
                Console.Write(numbers[i]);
                if(i < numbers.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine($" are {result}.");
        }

        /// <summary>
        /// Calculate the difference of some integer values and show result in console window
        /// </summary>
        static void Subtraction()
        {
            // Show a header for this subtraction function
            ShowAHeader("Subtraction");

            // Variables for calculation of the difference
            int[] numbers = GetSomeInteger();
            int result = 0;

            // Calculation of the difference and show the result in console window
            Console.Write("The difference of ");
            for(int i = 0; i < numbers.Length; i++)
            { 
                // Check if the number are first one
                if(i == 0)
                    result = numbers[i];
                else
                    result -= numbers[i];

                // Show the number that set or reduce the result
                Console.Write(numbers[i]);
                if(i < numbers.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine($" are {result}.");
        }
        /// <summary>
        /// Calculate the qouta from two integer values and show result in console window
        /// </summary>
        static void Divsion()
        {
            // Show a header for this divsion function
            ShowAHeader("Division");

            // Variables for calculation of the qouta
            int a, b;
            double result;

            // Ask the user for two integer values
            Console.Write("Write a number: ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("Write a other number and didn't allowed be zero: ");
            int.TryParse(Console.ReadLine(), out b);

            // Check if the secord number are zero or not
            if(b == 0)
                Console.WriteLine("The secord number are zero and it didn't allowed be that.");
            else
            {
                result = (double) a / b;
                Console.WriteLine($"The qouta from {a} and {b} are {Math.Round(result, 2)}.");
            }
        }
        /// <summary>
        /// Calculate the product from two integer values and show result in console window
        /// </summary>
        static void Multiplication()
        {
            // Show a header for this division function
            ShowAHeader("Multiplication");

            // Variables for calculation of the product
            int a, b;

            // Ask the user for two integer values
            Console.Write("Write a number: ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("Write a other number: ");
            int.TryParse(Console.ReadLine(), out b);

            // Calculation of the product and show the result in console window
            Console.WriteLine($"The product from {a} and {b} are {a * b}.");
        }
    }
}
