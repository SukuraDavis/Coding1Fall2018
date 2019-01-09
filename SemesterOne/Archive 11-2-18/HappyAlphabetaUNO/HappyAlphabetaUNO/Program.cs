using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyAlphabetaUNO
{
    class Program
    {
        static void Main(string[] args)
        {   

            char myChar = 'a';
            int myInt = myChar;

            for (int i = 0; i < 123; myInt++)
            {
                if (myInt <= 122)
                {
                    Console.WriteLine(myChar++ + " = " + myInt);
                    // Console.WriteLine("=");
                    // Console.WriteLine(myInt);
                    Console.ReadLine();
                }

                else
                {
                    break;
                   
                }
               
            }
        }
    }
}
