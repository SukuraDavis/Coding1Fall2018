using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert('l');
            tree.Insert('e');
            tree.Insert('p');
            tree.Insert('g');
            tree.Insert('f');
            tree.Insert('k');
            tree.Insert('a');
            tree.Insert('r');
            tree.Insert('o');
            tree.Insert('q');
            tree.Insert('m');
            tree.Insert('b');
            tree.Insert('n');
            tree.Insert('v');
            tree.Insert('i');
            tree.Insert('c');
            tree.Insert('y');
            tree.Insert('p');
            tree.Insert('a');
            tree.Insert('s');
            tree.Insert('j');
            tree.Insert('h');
            tree.Print();
            Console.ReadKey();
            tree.Remove('l');
            tree.Print();
            tree.InOrderPrint();
            Console.ReadKey();
            tree.Print();
            tree.PostOrderPrint();
            Console.ReadKey();
            tree.Print();
            tree.PreOrderPrint();
            Console.ReadKey();
            tree.Remove('e');
            tree.Print();
            Console.ReadKey();
            tree.Remove('a');
            tree.Print();
            
            Console.ReadKey();
            
            

        }
    }
}
