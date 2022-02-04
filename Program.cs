using System;
using System.Collections.Generic;

namespace ExampleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1 && args[0] == "test")
            {
                RunAllTests();
                return;
            }
        }

        public static void RunAllTests()
        {
            bool testGetPositiveInteger = TestGetPositiveInteger.RunTest();
            Console.WriteLine($"TestGetPositiveInteger: {testGetPositiveInteger}");
            bool testIsPositiveInteger = TestIsPositiveInteger.RunTest();
            Console.WriteLine($"TestIsPositiveInteger: {testIsPositiveInteger}");
        }

        /// <summary>
        /// Given a string to check, checks to see if the string is a positive integer.
        /// If the string is a positive integer, this returns true.
        /// If the string is null, throws a null pointer exception.
        /// Otherwise, returns false.
        /// </summary>
        /// <param name="toCheck">The string to check</param>
        /// <returns>True if the string is positive otherwise false </returns>
        public static bool IsPositiveInteger(string toCheck)
        {
            return false;
        }

        /// <summary>
        /// Given a prompt and a list of options, display the prompt to the user and list each
        /// options as a list starting with the number 1. 
        /// Then, wait for the user to enter a positive integer. 
        /// If the input is one of the listed opptions, returns that input as a number.
        /// Otherwise, displays 'Invalid' and prompts the user again.
        /// </summary>
        /// <param name="prompt">The message to prompt</param>
        /// <param name="options">A list of options to choose from this list must contain at least 1 option</param>
        /// <returns>The positive int that the user entered</returns>
        public static int GetValidOption(string prompt, List<string> options)
        {
            return -1;
        }
    }
}
