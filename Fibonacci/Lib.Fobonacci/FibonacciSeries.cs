using System;
using System.Collections.Generic;

namespace Lib.Fobonacci
{
    /// <summary>
    /// Fibonacci series generator
    /// </summary>
    public class FibonacciSeries
    {
        /// <summary>
        /// Generate 'Count' Number of Fibonacci series starting from 0
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public static int[] Generate(int count)
        {
            List<int> list = null;

            if (count > 0)
            {
                list = new List<int>() { 0 };
                if(count > 1)
                {
                    list.Add(1);
                    for (int i = 0; i < count-2; i++)
                    {
                        // If addition results in > max int value throw an exception
                        if((int.MaxValue - list[list.Count - 1] ) >= list[list.Count-2])
                        {
                            int newVal = list[list.Count - 2] + list[list.Count - 1];
                            list.Add(newVal);
                        }
                        else
                        {
                            // If addition results in > max int value throw an exception
                            throw new OverflowException("Fibonacci generation stopped due to int overflow");
                        }
                    }
                }
            }

            return list?.ToArray();
        }
    }
}
