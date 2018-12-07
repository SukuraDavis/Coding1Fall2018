using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(5);
            
            Console.ReadKey();
        }

        static void Print(int a)
        {
            Console.WriteLine("Printing integer: " + a);
        }

        static void Print(int[] array)
        {
          int[] arrayy = new int[5];
        }
        
        static void Print(int[,] array)
        {

        }

        static void Print(int[][] array)
        {

        }
    }
}
