using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BinarySearch");
            Console.WriteLine();
            BinarySearch(new int[5] { 2, 4, 5, 6, 8 }, 9);
            Console.ReadLine();

        }
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            bool foundValue = false;
            int middleIndex = inputArray.Length / 2;
            
            Console.Write("Original Array = ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Search Value = " + searchValue);
            Console.WriteLine();

            while (middleIndex < inputArray.Length)
            {
                if (inputArray[middleIndex] == searchValue)
                {
                    foundValue = true;
                    break;
                }
                if (middleIndex == 0)
                {
                    break;
                }
                if (middleIndex == inputArray.Length -1)
                {
                    break;
                }
                if (inputArray[middleIndex] > searchValue)
                {
                    middleIndex = middleIndex - (middleIndex / 2);
                }
                if (inputArray[middleIndex] < searchValue && middleIndex != 1)
                {
                    middleIndex = middleIndex + (middleIndex / 2);
                }
                if (inputArray[middleIndex] > searchValue && middleIndex == 1)
                {
                    middleIndex = middleIndex - 1;
                }
            }
            if (foundValue == false)
            {
                Console.WriteLine($"Search Value Index = -1");
                return -1;
            }
            else
            {
                Console.WriteLine($"Search Value Index = {middleIndex}");
                return middleIndex;
            }
        }
    }
}
