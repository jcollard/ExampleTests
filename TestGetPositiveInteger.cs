using System;

namespace ExampleTests
{
    class TestGetPositiveInteger
    {

        public static bool RunTest()
        {
            
            Console.WriteLine("Testing GetPositiveInteger.");
            Console.WriteLine("You should expect to see the message 'How old are you?'");
            Console.WriteLine("1. Enter '-5'. This should display 'Invalid.' and ask again.");
            Console.WriteLine("2. Enter '0'. This should display 'Invalid' and ask again.");
            Console.WriteLine("3. Just press enter (do not enter anything). This should display 'Invalid' and ask again.");
            Console.WriteLine("4. Enter '17'. This should be successful.");
            int testResult = Program.GetPositiveInteger("How old are you?");
            int expected = 17;
            if (testResult != expected)
            {
                Console.Error.WriteLine($"Failure: Expected 17 but the result was {testResult}.");
                return false;
            }

            return true;
        }
    }
}