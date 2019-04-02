using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTLevel_Order_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insert nodes into a Binary tree.
            Node root = new Node(3);
            root.left = new Node(2);
            root.right = new Node(5);
            root.left.left = new Node(1);
            root.right.left = new Node(4);
            root.right.right = new Node(7);

            //use Queue data structure to traverse the binary tree and print the nodes
            Queue myQ = new Queue();
            int height = getHeight(root);
            Console.WriteLine("height of binary tree: " + height);
            myQ.Enqueue(root.data);
            myQ.Enqueue(null);

            /* Queue helps in moving the pointer from one node to its child without losing reference because
             * we are storing the reference and since queue is a FIFO the node that is discovered first
             * and inserted first will be visited first.     
            */ 

            //while (myQ.Count > 0)
            //{
                Console.WriteLine("No of elements in the queue: {0}", myQ.Count);
                Console.WriteLine("Node Visited: " + myQ.Dequeue());
                Console.WriteLine("Number of elements in the Queue: {0}", myQ.Count);
                var currNode = root.data;
                Console.WriteLine("Visit current node and print its value: " + currNode);
                Console.WriteLine("enqueue its children");
                myQ.Enqueue(root.left);
                myQ.Enqueue(root.right);
                Console.WriteLine("Number of elements in the Queue: {0}", myQ.Count);


            //}







        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }

        public static int getHeight(Node root)
        {
            //Write your code here
            int height = 0;

            if (root == null)
                return -1;

            int left = getHeight(root.left);           
            int right = getHeight(root.right);
            if (left > right)
            {
                height = 1 + left;
            }
            else
            {
                height = 1 + right;
            }    

            //return Math.Max(left, right);
            return height;
        }
    }
}
