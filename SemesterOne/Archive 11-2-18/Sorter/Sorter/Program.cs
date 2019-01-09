using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
              
            int yee = 0;
           Random dappledee = new Random(yee);

            for (int weee = 0; weee < array.Length; weee++)
            {
                {
                    array[weee] = dappledee.Next(0, 10);
                }
                for (int scree = 9; scree < array.Length; scree++)
                {
                   array[scree] = weee;
                   Console.WriteLine(array[weee] = array[scree]);
                    
                    
                }
            }

            Console.ReadKey();
        }
    }
}
