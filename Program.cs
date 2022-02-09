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
            bool testIsPositiveInteger = TestIsPositiveInteger.RunTest();
            Console.WriteLine($"TestIsPositiveInteger: {testIsPositiveInteger}");
            bool testGetPositiveInteger = TestGetPositiveInteger.RunTest();
            Console.WriteLine($"TestGetPositiveInteger: {testGetPositiveInteger}");
            
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
            if (toCheck == null)
            {
                throw new Exception("Cannot parse a null string.");
            }
            try {
                int value = int.Parse(toCheck);
                if (value <= 0)
                {
                    return false;
                }
                else // (value > 0)
                {
                    return true;
                }
            } 
            catch 
            {
                return false;
            }
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
