using Hashtable.Classes;
using System;

namespace RepeatedWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Receives a string of words and returns first repeated word or "no repeated words" if no repeated words are found.
        /// </summary>
        /// <param name="book"></param>
        /// <returns>string first repeated word.</returns>
        public static string RepeatedWord(string book)
        {
            // Delimiting chars to use when splitting the book.
            char[] delimiters = new char[] { ' ', '.', '?', '!', ',', ';' };

            // Splits words found in book into an array of lowercase words.
            string[] words = book.ToLower().Split(delimiters);

            // Creates a container to hold all visted words with a size that is equal to the total number of words in the book.
            HashTable recordedWords = new HashTable(book.Length);

            // Steps through the words array.
            for (int i = 0; i < words.Length; i++)
            {
                // If the hashtable already contains index then return index
                if (recordedWords.Contains(words[i]))
                {
                    return words[i];
                }
                // Adds index to hashtable
                recordedWords.Add(words[i], null);
            }

            // Return if no repeats are found.
            return "no repeated words";
        }
    }    
}
