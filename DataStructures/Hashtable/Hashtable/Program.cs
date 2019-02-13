using System;
using Hashtable.Classes;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            JLHHashtable testHashTable = new JLHHashtable(5);
            Console.WriteLine(testHashTable.Hasher("Pioneer Square"));
            Console.WriteLine(testHashTable.Hasher("Alki Beach"));
            Console.WriteLine(testHashTable.Hasher("U District"));
            Console.WriteLine(testHashTable.Hasher("Seattle"));
            Console.WriteLine(testHashTable.Hasher("Renton"));
            Console.WriteLine(testHashTable.Hasher("Seatown"));
            Console.WriteLine(testHashTable.Hasher("Monroe"));


            testHashTable.Add("Pioneer Square", 98104);
            testHashTable.Add("Alki Beach", 98116);
            testHashTable.Add("U District", 98105);
            testHashTable.Add("Seattle", 98101);
            testHashTable.Add("Renton", 98055);

            Console.WriteLine(testHashTable.Get("Pioneer Square"));
            Console.WriteLine(testHashTable.Get("Alki Beach"));
            Console.WriteLine(testHashTable.Get("U District"));
            Console.WriteLine(testHashTable.Get("Seattle"));
            Console.WriteLine(testHashTable.Get("Renton"));

            Console.WriteLine(testHashTable.Contains("Pioneer Square"));
            Console.WriteLine(testHashTable.Contains("Alki Beach"));
            Console.WriteLine(testHashTable.Contains("U District"));
            Console.WriteLine(testHashTable.Contains("Seattle"));
            Console.WriteLine(testHashTable.Contains("Renton"));
            Console.WriteLine(testHashTable.Contains("Seatown"));
            Console.WriteLine(testHashTable.Contains("Monroe"));



            Console.ReadLine();
        }
    }
}
