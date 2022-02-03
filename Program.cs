using System;

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
        /// Given a string prompt, display the prompt to the user. Then, wait
        /// for the user to enter a positive integer. If the input is positive
        /// returns that input as an integer otherwise displays Invalid and prompts the
        /// user to enter a positive integer
        /// </summary>
        /// <param name="prompt">The message to prompt</param>
        /// <returns>The positive int that the user entered</returns>
        public static int GetPositiveInteger(string prompt)
        {
            return -1;
        }
    }
}
