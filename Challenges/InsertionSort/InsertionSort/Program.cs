using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int j = 0;
                if (i > 0)
                {
                    j = i - 1;
                };
                 
                int target = array[i];
                int previous = array[j];
                while (target < previous && j >= 0)
                {
                    array[j] = target;
                    array[j + 1] = previous;
                    if (j > 0)
                    {
                        previous = array[j - 1];
                    }   
                    j = j - 1;
                }
            }
            return array;
        }
    }
}
