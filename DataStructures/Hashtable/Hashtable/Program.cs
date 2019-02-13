using System;
using Hashtable.Classes;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            JLHHashtable testHashTable = new JLHHashtable(20);
            Console.WriteLine(testHashTable.Hasher("Pioneer Square"));
            Console.WriteLine(testHashTable.Hasher("Alki Beach"));
            Console.WriteLine(testHashTable.Hasher("U District"));
            Console.WriteLine(testHashTable.Hasher("Seattle"));
            Console.WriteLine(testHashTable.Hasher("Renton"));
            Console.WriteLine(testHashTable.Hasher("asdfsdfasdfasdfsadfasdfasasdfsafsaddfsdfsadfeererfsddfcasdvasdfasfdsffssdfddfdfd"));
            Console.ReadLine();
        }
    }
}
