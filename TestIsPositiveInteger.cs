using System;

namespace ExampleTests
{
    class TestIsPositiveInteger
    {

        public static bool RunTest()
        {
            string testInput = "5";
            bool testResult = Program.IsPositiveInteger(testInput);
            bool expected = true;
            if (testResult != expected)
            {
                Console.Error.WriteLine($"Failure: Expected '5' to be to true but was actually {testResult}");
                return false;
            }

            string testInput2 = "-2";
            bool testResult2 = Program.IsPositiveInteger(testInput2);
            bool expected2 = false;

            if (testResult2 != expected2)
            {
                Console.Error.WriteLine($"Failure: Expected false but was actually {testResult2}");
                return false;
            }

            testInput = "3.5";
            expected = false;
            testResult = Program.IsPositiveInteger(testInput);

            if (testResult != expected)
            {
                Console.Error.WriteLine($"Failure: Expected true but was actually {testResult}");
                return false;
            }

            try
            {
                testResult = Program.IsPositiveInteger(null);

                Console.Error.WriteLine("Failure: Expected the program to crash. But it did not.");
                return false;
            }
            catch
            {

            }

            // Our method seems to be working
            return true;
        }
    }
}