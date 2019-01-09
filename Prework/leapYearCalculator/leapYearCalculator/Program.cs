using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapYearCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap Year Calculator");
            Console.WriteLine("Please Enter a Year");

            int year = int.Parse(Console.ReadLine());
            bool leapYear = false;

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    leapYear = false;
                    
                }
                else
                {
                    leapYear = true;
                    
                }
            }
            Console.WriteLine("Is " + year + " a leap year? " + leapYear);
            Console.ReadLine();
        }
    }
}
