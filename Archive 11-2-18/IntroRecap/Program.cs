using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static int input = 0;
        static void Main(string[] args)
        {

            while (input != 4)
            {
                Console.WriteLine("1. Prints a 3x3 square");
                Console.WriteLine("2. Prints a triangle");
                Console.WriteLine("3. Prints the same triangle in reverse");
                Console.WriteLine("4. Exit the program");


                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Print3x3Square(3);
                    //Prints a size by a size


                }

                if (input == 2)
                {
                    PrintTriangle();
                }

                if (input == 3)
                {
                    PrintDifferentTriangle();
                }


            }
        }
        static void Print3x3Square(int size)
        { // ^ This a Parameter
            // "size" = the size of the square to print. In this, it is 3. (look at if statement for size number)
            Console.WriteLine(input);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("X");

                }
                Console.WriteLine();
            }


        }
        static void PrintTriangle()
        {   // ^ This is a Method
            Console.WriteLine(input);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write("X");
                }
                Console.WriteLine();

            }

        }
        static void PrintDifferentTriangle()
        {   // ^ This is a Method
            Console.WriteLine(input);
            int i, j, k = (2 * 6) - 2;

            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < k; j++)
                {
                    Console.Write(" ");
                }

                k = k - 1;

                for (j = 0; j <= i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();

            }

        }
    }
}
