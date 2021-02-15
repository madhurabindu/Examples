using Lib.Fobonacci;
using System;

namespace Main.Fibonacci
{
    /// <summary>
    /// Default Program Class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main function: Entry point of console app
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Test all conditions of fibonacci series generation
            TestFibonacci test = new TestFibonacci();
            test.TestAll();

            test.TestRecursive();
        }
    }
}
