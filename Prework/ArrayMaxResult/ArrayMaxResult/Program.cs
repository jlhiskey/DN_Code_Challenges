using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Max Result");
            Console.WriteLine("Please select a number between 1-10");

            int[] numberArray = new int[5];

            for(int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("You Selected " + numberArray[i] + ". You have " + (numberArray.Length - (i + 1)) + " choices left."); 
            }

            Console.Clear();
            Console.WriteLine("Please select a number between 1-10 for scoring");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine("You selected " + score + ". Press enter to calculate your tally.");
            Console.ReadLine();
        int tally = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] == score)
                {
                    tally += numberArray[i];
                }
            }
            Console.Clear();
            Console.WriteLine("Your tally is " + tally);
            Console.ReadLine();
        }
    }
}
