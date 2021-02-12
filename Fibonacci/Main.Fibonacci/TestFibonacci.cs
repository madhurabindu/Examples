using Lib.Fobonacci;
using System;

namespace Main.Fibonacci
{
    /// <summary>
    /// Class to test the FibonacciSeries class
    /// </summary>
    public class TestFibonacci
    {
        /// <summary>
        /// Test All Functions
        /// </summary>
        public void TestAll()
        {
            TestFewGoodNumbers();
            TestRandomly();

            TestMin();
            TestNegative();
            TestIntMax();
        }

        /// <summary>
        /// Test Few good numbers
        /// </summary>
        private void TestFewGoodNumbers()
        {
            TestRoutine(5);
            TestRoutine(10);
            TestRoutine(15);
        }

        /// <summary>
        /// Test Count generated radomly
        /// </summary>
        private void TestRandomly()
        {
            Random rand = new Random(int.MaxValue);
            TestRoutine(rand.Next(1, 10));
            TestRoutine(rand.Next(1, 10));
            TestRoutine(rand.Next(11,30));
            TestRoutine(rand.Next(11, 30));
            TestRoutine(rand.Next(31,45));
            TestRoutine(rand.Next(31, 45));
        }
        /// <summary>
        /// Test Minimum Number of entries
        /// </summary>
        private void TestMin()
        {
            TestRoutine(0);
            TestRoutine(1);
            TestRoutine(2);
        }
        /// <summary>
        /// Test the Max Int Limit
        /// </summary>
        private void TestIntMax()
        {
            TestRoutine(47);
            TestRoutine(48);
            TestRoutine(49);
        }
        /// <summary>
        /// Test negative number for count
        /// </summary>
        private void TestNegative()
        {
            TestRoutine(-10);
        }

        /// <summary>
        /// Generic Test Routine
        /// </summary>
        /// <param name="count"></param>
        private void TestRoutine(int count)
        {
            Console.WriteLine("------- The [{0}] Number of Fibonacci Series ------ ", count);
            try
            {
                int[] series = FibonacciSeries.Generate(count);
                if (series != null)
                {
                    Console.WriteLine(string.Join("\n", series));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Generating {0} number of Fibonacci Series\n{1}", count, ex.Message);
            }
            Console.WriteLine("-------------------------------------------------\n\n");
        }
    }
}
