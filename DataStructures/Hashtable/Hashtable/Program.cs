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

            testHashTable.Add("Pioneer Square", 98104);
            testHashTable.Add("Alki Beach", 98116);
            testHashTable.Add("U District", 98105);
            testHashTable.Add("Seattle", 98101);
            testHashTable.Add("Renton", 98055);

            //HashNode pioneerSquare = testHashTable.Get("Pioneer Square");
            //HashNode alkiBeach = testHashTable.Get("Alki Beach");
            var uDistrict = testHashTable.Get("U District");
            var seattle = testHashTable.Get("Seattle");
            //HashNode renton = testHashTable.Get("Renton");


            Console.ReadLine();
        }
    }
}
