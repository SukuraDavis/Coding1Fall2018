using System;
using System.Linq;

namespace StringTimes
{
    class Program
    { 
        
        static void Main(string[] args)
        {

            StringTimes("Hi", 2);
            string o = StringTimes("Hi", 5);
            Console.WriteLine(o);
            Console.ReadKey();



        }

        static string StringTimes(string h, int g)
        {
            //  string k = string.Join("", Enumerable.Repeat(h, g));

            string k = "";

            for (int i = 0; i < g; i++)
            {
                k += h;
            }

            return k;

        }

        static void stringsplosion()
        {
            Console.WriteLine("Please enter a string");
            string result = Console.ReadLine();

            for (int i = 0; i < result.Length; i++)
            {

                for (int y = 0; y < i + 1; y++)
                {
                    Console.Write(result[y]);



                }


            }
            Console.ReadLine();

        }

        static void stringBits()
        {
            Console.WriteLine("Please enter a string");
            string result = Console.ReadLine();

            for (int i = 0; i < result.Length; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write(result[i]);
                }


            }
            Console.ReadLine();
        }

        
            
        

        
            
        
    }
    

}

