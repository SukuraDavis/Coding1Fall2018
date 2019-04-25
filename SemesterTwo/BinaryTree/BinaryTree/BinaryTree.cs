using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        private Node Root { get; set; }
        
        public int Height { get { return Root != null ? Root.Height : 0; } }

        public int Count { get { return Root != null ? CountRecursive(Root) : 0; } }

        public void Print()
        {
            BinaryTreePrinter.printNode(Root);
            
        }
       
        private int CountRecursive(Node val)
        {

            int left = 0; 
            int right = 0; 
            //int both = 0;
            if (val.RightChild != null)
            {

                right = CountRecursive(val.RightChild);
                
                

            }
            if (val.LeftChild != null)
            {

                left = CountRecursive(val.LeftChild);



            }

            return left + right + 1;



        }

        public void Insert(char val)
        {
            if (Root == null)
            {
                Root = new Node(val);
            }

            else
            {
                Insert(Root, val);
            }
        }

        private void Insert(Node cur, char val)
        {
            if (val >= cur.Value && cur.RightChild == null)
            {
                cur.RightChild = new Node(val);
                return;
            }

            if (val < cur.Value && cur.LeftChild == null)
            {
                cur.LeftChild = new Node(val);
                return;
            }

            if (val >= cur.Value)
            {
                Insert(cur.RightChild, val);
            }

           else if (val < cur.Value)
           {
                Insert(cur.LeftChild, val);
           }
        }

        public void Remove(char val)
        {
            Root = Remove(Root, val);
        }

        private Node Remove(Node cur, char val) //Node root, int key
        {
            /* Base Case: If the tree is empty */
            if (cur == null) return cur;

            /* Otherwise, recur down the tree */
            if (val < cur.Value)
                cur.LeftChild = Remove(cur.LeftChild, val);
            else if (val > cur.Value)
                cur.RightChild = Remove(cur.RightChild, val);

            // if key is same as root's key, then This is the node  
            // to be deleted  
            else
            {
                // node with only one child or no child  
                if (cur.LeftChild == null)
                    return cur.RightChild;
                else if (cur.RightChild == null)
                    return cur.LeftChild;

                // node with two children: Get the 
                // inorder successor (smallest  
                // in the right subtree)

                Node temp = cur.RightChild;

                char minv = temp.Value;
                while (temp.LeftChild != null)
                {
                    minv = temp.LeftChild.Value;
                    temp = temp.LeftChild;
                }

                //cur.Value = minv(cur.RightChild);

               
                cur.Value = minv;

                //Delete the inorder successor  
                cur.RightChild = Remove(cur.RightChild, cur.Value);
            }
            return cur;
        }

        

        public bool Search (char val)
        {
            if (Root == null)
            {
                return false;
                
            }

            else
            {
               return Search(Root, val);
            }
        }

        private bool Search(Node cur, char val)
        {

            if (val > cur.Value && cur.RightChild != null)
            {
               return Search(cur.RightChild, val);
                
            }

           

            if (val < cur.Value && cur.LeftChild != null)
            {
               return Search(cur.LeftChild, val);
                
            }

          

            if (val == cur.Value)
            {
                return true;
            }

            return false;

            
        }

        public void PreOrderPrint()
        {
            PreOrderPrint(Root);
        }

        private void PreOrderPrint(Node val)
        {
            if (val != null)
            {
                Console.Write(val.Value + " ");
                PreOrderPrint(val.LeftChild);
                PreOrderPrint(val.RightChild);
            }
        }

        public void InOrderPrint()
        {
            InOrderPrint(Root);
        }

        private void InOrderPrint(Node val)
        {
            
            if (val != null)
            {
                InOrderPrint(val.LeftChild);
                Console.Write(val.Value + " ");
                InOrderPrint(val.RightChild);
            }
        }

        public void PostOrderPrint()
        {
            PostOrderPrint(Root);
        }

        private void PostOrderPrint(Node val)
        {
            if (val != null)
            {
                PostOrderPrint(val.LeftChild);
                PostOrderPrint(val.RightChild);
                Console.Write(val.Value + " ");
            }
        }
    }
}
