using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfRows
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of Rows");

            Console.WriteLine("How many rows do you have?");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("How many columns do you have?");
            int columns = int.Parse(Console.ReadLine());

            int selections = rows * columns;

            int[,] twoDArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("You have " + selections + " selections remaining");
                    twoDArray[i,j] = int.Parse(Console.ReadLine());
                    Console.WriteLine("You Selected " + twoDArray[i, j]);
                    selections = selections - 1;
                }
            }
            int[] total = new int[rows];
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum = sum + twoDArray[i,j];
                }
                total[i] = sum;
                sum = 0;
            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("The sum of Row " + (i + 1) + " = " + total[i]);
            }
            Console.ReadLine();
        }
    }
}