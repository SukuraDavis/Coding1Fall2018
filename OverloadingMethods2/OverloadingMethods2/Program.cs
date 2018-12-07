using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parameters (f)
            Print(2.122222222222);
        }

        static void Print(double f)
        {
            Console.WriteLine("The double is " + f);

            string n = f.ToString("0.##");
            string k = f.ToString("0");
       
            Console.WriteLine("The float is " + n);

            Console.WriteLine("The integer is " + k);
            Console.ReadKey();
        }
    }
}
