using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderr
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            
            while (input != 4)
            {
                Console.WriteLine("Type the number to the action that you want to perform: ");
                Console.WriteLine("1. Write the text to text file IO-Doc.txt");
                Console.WriteLine("2. Read a single line of the text from text file IO-Doc.txt");
                Console.WriteLine("3. Read all the lines of the text from text file IO-Doc.txt");
                Console.WriteLine("4. Exit the program");
                
                
                input = int.Parse(Console.ReadLine());

                Console.WriteLine(" ");
              

                if (input == 1)
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

                if (input == 2)
                {
                   string path = @"C:\Users\138692\Documents\Coding1Fall2018\11-14-18+\IO-Doc.txt";

                    string result;
                    using (StreamReader sr = new StreamReader(path))
                    {

                        result = sr.ReadLine();
                        
                    }
                    Console.WriteLine(result);
                    Console.WriteLine(" ");
                }
                    
                

                if (input == 3)
                {
                    string path = @"C:\Users\138692\Documents\Coding1Fall2018\11-14-18+\IO-Doc.txt";

                    List<string> file = new List<string>();
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            file.Add(line);
                            Console.WriteLine(line);
                            
                        }
                        Console.WriteLine(" ");
                    }
                    
                }
            }
            
        }
    }
}
