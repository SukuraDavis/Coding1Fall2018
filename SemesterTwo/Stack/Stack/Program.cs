using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Stack myStack = new Stack();

            while (input != 5)
            {
                Console.WriteLine("1. Push a value to the top of the stack");
                Console.WriteLine("2. Peek at the top value of the stack");
                Console.WriteLine("3. Pop the top value from the stack");
                Console.WriteLine("4. Prints the stack");
                Console.WriteLine("5. Exit the program.");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {

                    int input2;
                    Console.WriteLine(" ");
                    Console.Write("What number would you like to add?: ");
                    input2 = int.Parse(Console.ReadLine());

                    myStack.Push(input2);
                    Console.WriteLine(" ");

                }

                if (input == 2)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("SPOOKY!!! " + myStack.Peek() + " is your peeked number.");
                    Console.WriteLine(" ");
                    //myStack.Peek();
                   
                }

                if (input == 3)
                {
                    myStack.Pop();
                }

                if (input == 4)
                {
                    myStack.Print();
                }
            }

            
        }
    }
}
