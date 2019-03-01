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

        
            
        
    }
    

}

