using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    class Queue<T> : IEmptyable, IPrintable, ICountable where T : IComparable
    {
        List<T> holder = new List<T>();
        //original: List<int> holder = new List<int>();

        //All variable names (like int) within method name has been changed to T

        public Queue()
        {

        }

        //push
        public void EnQueue(T val)
        {
            holder.Insert(0, val);
        }

        //pop
        public T DeQueue()
        {


            //  T temp = holder[holder.Count - 1];
            //   holder.RemoveAt(holder.Count - 1);
            //   return temp;

            T first;
            first = holder[holder.Count - holder.Count];
            Console.WriteLine(" ");
            Console.WriteLine(holder[holder.Count - holder.Count] + " has been popped!");
            Console.WriteLine(" ");
            holder.Remove(first);
            return first;

        }

        //peek
        public T Peek()
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

            //foreach(T in holder)
            //{ 
            // t.holder;
            //}
        }

        public void Empty()
        {
            holder.Clear();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void search()
        {
            //if val == holder[i]
            //if val.CompareTo(holder[i]) == 0
        }

        
    }
}
