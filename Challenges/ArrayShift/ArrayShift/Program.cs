using System;

namespace ArrayShift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Shift");
            Console.WriteLine();
            ArrayShift(new int[4] { 2, 4, 6, 8 }, 5);
            Console.ReadLine();

        }
        static int[] ArrayShift(int[] inputArray, int insertedValue)
        {
            int[] savedArray = inputArray;
            int arraySize = savedArray.Length;
            int middleIndex = 0;

            middleIndex = arraySize / 2;

            Console.Write("Original Array = ");
            for (int i = 0; i < savedArray.Length; i++)
            {
                Console.Write(savedArray[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Inserted Value = " + insertedValue);
            Console.WriteLine();

            int[] newArray = new int[arraySize + 1];
            for (int i = 0; i < middleIndex; i++)
            {
                newArray[i] = savedArray[i];
            }
            newArray[middleIndex] = insertedValue;
            for (int i = middleIndex + 1; i < newArray.Length; i++)
            {
                newArray[i] = savedArray[i - 1];
            }
            Console.Write("New Array = ");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + ",");
            }
            return newArray;
        }
    }
}