using System;

namespace FibNum
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FibNum(12));
        }

        /// <summary>
        /// Uses Golden Ratio and param "n" to determine value of Fibonacci Sequence at (n)th position.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Returns integer value</returns>
        public static int FibNum(double n)
        {
            // Sets X as a variable
            double x = 0;

            // Calculates Golden Ratio
            double goldenRatio = (1 + Math.Sqrt(5.0)) / 2;

            // Uses Golden Ratio to Calculate Fibonacci Number at the nth step of the sequence.
            x = (Math.Pow(goldenRatio, n) - Math.Pow((1 - goldenRatio), n)) / Math.Sqrt(5.0); // Time: O(1) Space: O(1) ;)

            // Coverts double to int
            int intParseX = Convert.ToInt32(x);
            // returns value as an int.
            return intParseX;
        }
    }
}
