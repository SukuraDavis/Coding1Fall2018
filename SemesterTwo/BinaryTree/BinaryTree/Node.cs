using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public char Value {get; set;}
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Height
        {
            get
            {
                int leftTreeHeight = 0;
                int rightTreeHeight = 0;

                if (LeftChild != null)
                {
                    leftTreeHeight = LeftChild.Height + 1;
                }

                if (RightChild != null)
                {
                    rightTreeHeight = RightChild.Height + 1;
                }

                if (leftTreeHeight > rightTreeHeight)
                {
                    return leftTreeHeight;
                }

                else
                {
                    return rightTreeHeight;
                }
            }
            
        }

        public Node(char val)
        {
            Value = val;
        }
    }
}
