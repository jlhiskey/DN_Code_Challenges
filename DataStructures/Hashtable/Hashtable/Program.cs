using System;
using Hashtable.Classes;

namespace Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            JLHHashtable testHashTable = new JLHHashtable(5);

            Console.WriteLine("Hash Key Method");
            Console.WriteLine();

            testHashTable.Hasher("Pioneer Square");
            testHashTable.Hasher("Alki Beach");
            testHashTable.Hasher("U District");
            testHashTable.Hasher("Seattle");
            testHashTable.Hasher("Renton");
            testHashTable.Hasher("Seatown");
            testHashTable.Hasher("Monroe");

            Console.WriteLine();
            Console.WriteLine("Add Method");
            Console.WriteLine();

            testHashTable.Add("Pioneer Square", 98104);
            testHashTable.Add("Alki Beach", 98116);
            testHashTable.Add("U District", 98105);
            testHashTable.Add("Seattle", 98101);
            testHashTable.Add("Renton", 98055);

            Console.WriteLine();
            Console.WriteLine("Get Method");
            Console.WriteLine();

            testHashTable.Get("Pioneer Square");
            testHashTable.Get("Alki Beach");
            testHashTable.Get("U District");
            testHashTable.Get("Seattle");
            testHashTable.Get("Renton");

            Console.WriteLine();
            Console.WriteLine("Contain Method");
            Console.WriteLine();

            testHashTable.Contains("Pioneer Square");
            testHashTable.Contains("Alki Beach");
            testHashTable.Contains("U District");
            testHashTable.Contains("Seattle");
            testHashTable.Contains("Renton");
            testHashTable.Contains("Seatown");
            testHashTable.Contains("Monroe");

            Console.WriteLine();
            Console.WriteLine("Remove Method");
            Console.WriteLine();

            testHashTable.Remove("Pioneer Square");
            testHashTable.Remove("Alki Beach");
            testHashTable.Remove("U District");
            testHashTable.Remove("Seattle");
            testHashTable.Remove("Renton");


            Console.ReadLine();
        }
    }
}
