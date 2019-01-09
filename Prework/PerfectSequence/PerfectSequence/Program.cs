using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfect Sequence");
            Console.WriteLine("How many numbers do you want to enter?");
            int totalNumbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select a number.");

            int[] numberArray = new int[totalNumbers];

            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("You Selected " + numberArray[i] + ". You have " + (numberArray.Length - (i + 1)) + " choices left.");
            }

            bool perfectSequence = false;
            int sum = 0;
            int product = numberArray[0];

            for (int i = 0; i < numberArray.Length; i++)
            {
                sum = sum + numberArray[i];
            }

            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                product = product * numberArray[i + 1];
            }

            if (sum == product)
            {
                perfectSequence = true;
            }


            Console.WriteLine("Are your numbers a perfect sequence? " + perfectSequence);
            Console.ReadLine();
        }
    }
}
