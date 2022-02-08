using System;

namespace ExampleTests
{
    class TestIsPositiveInteger
    {

        public static bool RunTest()
        {
            bool result = Program.IsPositiveInteger("hashtag");
            bool expected = false;

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected {expected} but the result was {result}");
                return false;
            }

            try 
            {
                Program.IsPositiveInteger(null);
                Console.Error.WriteLine($"Failure: Expected an exception but there was none.");
                return false;
            }
            catch 
            {

            }

            result = Program.IsPositiveInteger("2");
            expected = true;

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected {expected} but the result was {result}");
                return false;
            }

            return true;
        }
    }
}