using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(3);
            Console.WriteLine(root.data);
            root.left = new Node(2);
            root.right = new Node(5);
            root.left.left = new Node(1);
            root.right.left = new Node(4);
            root.right.right = new Node(6);
            root.right.right.right = new Node(7);
            Console.WriteLine(root.right.right.right.data);

        }
    }
}
