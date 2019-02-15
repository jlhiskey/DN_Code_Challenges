using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test One");
            int[] testArray = new int[] { 5, 4, 3, 2, 1 };

            Console.WriteLine("Before Sort");
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine(testArray[i]);
            }

            InsertionSort(testArray);
            Console.WriteLine();

            Console.WriteLine("After Sort");
            for (int i = 0; i < testArray.Length; i++)
            {
                Console.WriteLine(testArray[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Test Two");
            int[] testArray2 = new int[] { 1, 4, 2, 3, 5 };

            Console.WriteLine("Before Sort");
            for (int i = 0; i < testArray2.Length; i++)
            {
                Console.WriteLine(testArray2[i]);
            }

            InsertionSort(testArray2);
            Console.WriteLine();

            Console.WriteLine("After Sort");
            for (int i = 0; i < testArray2.Length; i++)
            {
                Console.WriteLine(testArray2[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Test Three");
            int[] testArray3 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Before Sort");
            for (int i = 0; i < testArray3.Length; i++)
            {
                Console.WriteLine(testArray3[i]);
            }

            InsertionSort(testArray3);
            Console.WriteLine();

            Console.WriteLine("After Sort");
            for (int i = 0; i < testArray3.Length; i++)
            {
                Console.WriteLine(testArray3[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }

        /// <summary>
        /// Takes in an array of integers and sorts them with the lowest value starting at array[0] and returns original array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //keeping track of j for while loop
                int j = 0;

                //Sets value to j once i > 0
                if (i > 0)
                {
                    j = i - 1;
                };
                 
                // Setting initial values to work with
                int target = array[i];
                int previous = array[j];
                // Runs until target is less than previous value
                while (target < previous && j >= 0)
                {
                    //swaps previous with target
                    array[j] = target;
                    array[j + 1] = previous;
                    //resets previous
                    if (j > 0)
                    {
                        previous = array[j - 1];
                    }
                    //reduces j
                    j = j - 1;
                }
            }
            return array;
        }
    }
}
