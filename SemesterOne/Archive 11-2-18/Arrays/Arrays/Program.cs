using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myIntArray = new int[11]
                { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> myIntList = new List<int>()
                {  0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myIntArray[0] = 1;

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                
                myIntArray[i] = rand.Next();
                Console.WriteLine(myIntArray[i]);


            }

            

            int[] myIntArrayTwo = new int[11]
                { 0,1,2,3,4,5,6,7,8,9,10 };
            List<int> myIntListTwo = new List<int>()
            {  0,1,2,3,4,5,6,7,8,9,10 };
            

            int input = 4;
            while (input != 3)
            {
                Console.WriteLine("Enter the integer value for the action you want to perform.");
                Console.WriteLine("1. Array 0 - 10");
                Console.WriteLine("2. List 0 - 10");
                Console.WriteLine("3. Exit the program");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine(input);
                    Console.WriteLine(myIntArrayTwo);
                }

                else if (input == 2)
                {
                    Console.WriteLine(input);
                    Console.WriteLine(myIntListTwo);
                }

                else if (input == 3)
                {
                    Console.WriteLine(input);
                    Console.WriteLine("Exit the program.");
                }
            } 
            }
            

            
            





        }
    }

