﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Queue<int> myQueue= new Queue<int>();
            //Original: Queue myQueue= new Queue();
            //Because of <T> in the Queue class, you state the type of variable you'd like here

         


            while (input != 5)
            {
                Console.WriteLine("1. Push a value to the back of the queue");
                Console.WriteLine("2. Peek at the top value of the queue");
                Console.WriteLine("3. Pop the top value from the queue");
                Console.WriteLine("4. Prints the queue");
                Console.WriteLine("5. Exit the program.");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {

                    int input2;
                    Console.WriteLine(" ");
                    Console.Write("What number would you like to add?: ");
                    input2 = int.Parse(Console.ReadLine());

                    myQueue.EnQueue(input2);
                    Console.WriteLine(" ");

                }

                if (input == 2)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("SPOOKY!!! " + myQueue.Peek() + " is your peeked number.");
                    Console.WriteLine(" ");
                    //myStack.Peek();

                }

                if (input == 3)
                {
                    myQueue.DeQueue();
                }

                if (input == 4)
                {
                    myQueue.Print();
                }

                //Queue<Currencies> currencies = new Queue<Currencies>();
                //currencies.EnQueue(new Currencies(1, 0, 0));
                //currencies.EnQueue(new Currencies(0, 100, 10));
                //currencies.EnQueue(new Currencies(0, 10, 0));
                //currencies.EnQueue(new Currencies(1, 1, 0));

                //currencies.Print();
                //currencies.Sort();

                //Colsole.WriteLine();

                //currencies.Print();

                //for loop
                //currencies.Enqueue(new Currencies(rand.next(0,100), rand.next(0,100), rand.next(0,100)));
            }
        }
    }
}
