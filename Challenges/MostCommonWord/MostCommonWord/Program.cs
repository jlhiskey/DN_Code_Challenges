using System;
using Hashtable.Classes;

namespace MostCommonWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In a galaxy far far away");
            Console.WriteLine(MostCommonWord("In a galaxy far far away"));

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Taco cat ate a taco");
            Console.WriteLine(MostCommonWord("Taco cat ate a taco"));

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("No. Try not. Do or do not. There is no try.");
            Console.WriteLine(MostCommonWord("No. Try not. Do or do not. There is no try."));

            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            Console.ReadLine();

        }

        /// <summary>
        /// Takes in a string book and returns the most commonly used word in the book. A word is a substring with the book seperated by spaces.
        /// </summary>
        /// <param name="book"></param>
        /// <returns>string most commonly used word in book</returns>
        public static string MostCommonWord(string book)
        {
            //Container that will hold most common word.
            string mostCommonWord = "No Words in Book";
            //Counter that will keep track of highest counter returned
            int highestCounter = 0;
            //Splits book into an array of words.
            string[] words = book.Split(" ");
            // Will keep track of words found in book. 
            HashTable wordTracker = new HashTable(1024);

            for (int i = 0; i < words.Length; i++)
            {
                // If wordtracker contains the word then it will be pulled out of storage and its counter will be increased by one then the counter will be compared to the highestCounter. 
                if (wordTracker.Contains(words[i]))
                {
                    int counter = int.Parse(wordTracker.Storage[wordTracker.Hasher(words[i])].Value.ToString());
                    counter = counter + 1;

                    //If the counter is higher then the mostCommonWord will become that word and the highest counter will become the counter.
                    if (counter > highestCounter)
                    {
                        mostCommonWord = wordTracker.Storage[wordTracker.Hasher(words[i])].Key;
                        highestCounter = counter;
                    }
                    // Updates counter in storage
                    wordTracker.Storage[wordTracker.Hasher(words[i])].Value = counter;
                }
                
                //Adds new word to wordtracker and sets its counter to 1
                wordTracker.Add(words[i].ToLower(), 1);
                
                // Handles only unique words being input in the book.
                if (highestCounter == 0)
                {
                    mostCommonWord = words[i];
                    highestCounter = 1;
                }
            }

            return mostCommonWord;
        }
    }
}
