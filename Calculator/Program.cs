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
    }
}
