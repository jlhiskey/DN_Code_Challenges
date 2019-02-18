using System;
using System.Collections.Generic;

namespace AreCharactersUnique
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing: ABCD");
            Console.WriteLine(AreCharactersUnique("ABCD"));

            Console.WriteLine("Testing: ABCA");
            Console.WriteLine(AreCharactersUnique("ABCA"));

            Console.WriteLine("Testing: AabCD");
            Console.WriteLine(AreCharactersUnique("AabCD"));

            Console.ReadLine();
        }

        /// <summary>
        /// Takes an input of a string and returns a bool indicating if all characters within the string are unique.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool AreCharactersUnique(string input)
        {
            // Creates a dictionary that will keep track of all visted characters.
            Dictionary<char, char> visitedCharacters = new Dictionary<char, char>();
            // Iterates through the input string
            for (int i = 0; i < input.Length; i++)
            {
                //Checks if the dictionary contains a character that matches input at i. If it does it will end the loop and return false.
                if (visitedCharacters.ContainsKey(input[i]))
                {
                    return false;
                }
                //Adds input at i to visited characters.
                visitedCharacters.Add(input[i], input[i]);
            }
            return true;
        }
    }   
}
