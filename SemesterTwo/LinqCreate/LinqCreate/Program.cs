using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 5, 3, 8, 2 };
            
            int total = num.Sum(number => number / 5);
           



            //taking the average
            // Answer: 
            
            
           // double er = num.Average(numb => numb);
           



        }
    }
}
