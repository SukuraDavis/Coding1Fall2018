using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue
    {
        List<int> holder = new List<int>();

        public Queue()
        {

        }

        //push
        public void EnQueue(int val)
        {
            holder.Add(val);
        }

        //pop
        public int DeQueue()
        {

            int first;
            first = holder[holder.Count - holder.Count];
            Console.WriteLine(" ");
            Console.WriteLine(holder[holder.Count - holder.Count] + " has been popped!");
            Console.WriteLine(" ");
            holder.Remove(first);
            return first;

        }

        //peek
        public int Peek()
        {
            return holder[holder.Count - holder.Count];


        }

        //print
        public void Print()
        {
            for (int i = 0; i < holder.Count; i++)
            {

                Console.WriteLine(" ");
                Console.Write(holder[i]);


            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
