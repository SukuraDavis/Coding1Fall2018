using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyCharacteroUNO
{
    class Program
    {
        static void Main(string[] args)
        {

            int myInt = 97;
            char myChar = (char)myInt;

            for (myInt = 0; myInt < 13001; myChar++)
            {
                if (myInt <= 13000)
                {
                    Console.Write(myChar); 

                }

                else
                {
                    break;

                }
                Console.ReadLine();

            }
        }
    }
}
    

