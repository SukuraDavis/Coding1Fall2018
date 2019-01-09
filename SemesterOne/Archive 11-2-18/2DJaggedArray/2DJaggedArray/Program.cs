using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[10][];
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i * j;
                }
            }
            Print2DJaggedArray(jaggedArray);

            Console.ReadKey();
        }

        static void Print2DJaggedArray(int[][]Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                Array[i] = new int[i + 1];
                for (int j = 0; j < Array[i].Length; j++)
                {
                    Array[i][j] = i * j;
                    Console.Write(Array[i][j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
