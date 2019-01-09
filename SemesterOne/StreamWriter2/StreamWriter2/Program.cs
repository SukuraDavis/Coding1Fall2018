using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriter2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            
            
            while (input != 3)
            {
                Console.WriteLine("1. the using keyboard to the file IO-Doc.txt");
                Console.WriteLine("2. the variable path to/from someone of the file. In this case the file is IO-Doc.txt");
                Console.WriteLine("3. exit the program");
                input = int.Parse(Console.ReadLine());



                if (input == 1)
                {   //We will ALWAYS use the using keyboard instead of manually 
                    //disposing the stream
                    string path = @"C:\Users\138692\Documents\Coding1Fall2018\11-14-18+\IO-Doc.txt";
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine("Hello");
                        sw.WriteLine("World");
                    }
                }

                if (input == 2)
                {
                    //When someone else tries to use your code,
                    //it wont work because they wont have an identical 
                    //path signature.
                    //solve this by using local paths
                    string path;
                    path = @"C:\Users\138692\Documents\Coding1Fall2018\11-14-18+\IO-Doc.txt";
                    path = AppDomain.CurrentDomain.BaseDirectory + @"IO-Doc.txt";

                    //The variable path doesn't change!

                }

                
            }
        }
    }
}
