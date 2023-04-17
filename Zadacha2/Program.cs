using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < rows; row++)
            {
                long sumRow = 0;
                for (int col = 0; col < cols; col++)
                {
                    sumRow += matrix[row, col];
                    Console.Write("{0,10}" ,matrix[row, col] );
                }
                Console.WriteLine($"      {sumRow / (double)cols}");
            }   }
    }
}
