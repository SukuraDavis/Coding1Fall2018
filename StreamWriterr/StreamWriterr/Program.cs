using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterr
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\138692\Documents\Coding1Fall2018\11-14-18+\IO-Doc.txt";

            StreamWriter sw = new StreamWriter(path);

            int[] myIntArray = new int[11]
                { 0,1,2,3,4,5,6,7,8,9,10 };
          

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {

                myIntArray[i] = rand.Next();
                sw.WriteLine(myIntArray[i]);


            }
            sw.WriteLine("Numberz gone rAnDoMmMmMmMMmm");
            sw.Dispose();
            
        }
    }
}
