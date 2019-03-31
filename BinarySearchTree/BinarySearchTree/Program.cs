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
            //Console.WriteLine("root.data: " + root.data);
            root.left = new Node(2);
            //Console.WriteLine("root.left: " + root.left.data);
            root.right = new Node(5);
            //Console.WriteLine("root.right: " + root.right.data);
            root.left.left = new Node(1);
            //Console.WriteLine("root.left.left: " + root.left.left.data);
            root.right.left = new Node(4);
            //Console.WriteLine("root.right.left: " + root.right.left.data);
            root.right.right = new Node(6);
            //Console.WriteLine("root.right.right: " + root.right.right.data);
            root.right.right.right = new Node(7);
            //Console.WriteLine("root.right.right.right: " + root.right.right.right.data);
            

            int result = getHeight(root);
            Console.WriteLine("result: " + result);

        }

        public static int getHeight(Node root)
        {
            //Write your code here
            int height = 0;
            
            if (root == null) return -1;

            int left = getHeight(root.left);
            Console.WriteLine("left: " + root.left);
            int right = getHeight(root.right);
            Console.WriteLine("right: " + root.right);

            if (left > right)
            {
                 height = 1 + left;
                Console.WriteLine("If, height: " + height);
            }
            else
            {
                 height = 1 + right;
                Console.WriteLine("Else, height: " + height);
            }



            //return Math.Max(left, right);
            return height;
        }
    }
}
