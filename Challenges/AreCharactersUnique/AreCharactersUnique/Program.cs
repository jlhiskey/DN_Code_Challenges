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

        public static bool AreCharactersUnique(string input)
        {
            Dictionary<char, char> visitedCharacters = new Dictionary<char, char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (visitedCharacters.ContainsKey(input[i]))
                {
                    return false;
                }
                visitedCharacters.Add(input[i], input[i]);
            }
            return true;
        }
    }   
}
