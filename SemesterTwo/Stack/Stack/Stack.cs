using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Stack
{
    class Stack
    {
        List<int> holder = new List<int>();

        public Stack()
        {

        }

        //push
        public void Push(int val)
        {
            holder.Add(val);
        }
        
        //pop
        public int Pop()
        {
            int first;
            first = holder.Count - 1;
            Console.WriteLine(" ");
            Console.WriteLine(holder[holder.Count - 1] + " has been popped!");
            Console.WriteLine(" ");
            holder.RemoveAt(first);
            return first;
        }

        //peek
        public int Peek()
        {
           return holder[holder.Count - 1];
            
            
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
