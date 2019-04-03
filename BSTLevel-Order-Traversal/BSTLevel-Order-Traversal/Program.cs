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
            levelOrderTraversal(root);
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }

        /* Benefits of using a Queue to traverse a BST by levels 
        *    Queue helps in moving the pointer from one node to its child without losing reference because
        * we are storing the reference and since queue is a FIFO the node that is discovered first
        * and inserted first will be visited first.     
        */

        public static void levelOrderTraversal(Node root)
        {

            //use Queue data structure to traverse the binary tree and print the nodes
            Queue<Node> myQ = new Queue<Node>();
            Node currNode;
            
            if (root == null)
            {
                return;
            }
            else
            {
                myQ.Enqueue(root);
            }

                // while queue is not empty and has at least one node in it
                while (myQ.Count > 0)             
                {
                    Node nodeInFrontOfQueue = myQ.Peek();
                    // the dataType of the first element in a queue is a pointer to a node so we store it in Node variable
                    Console.WriteLine(nodeInFrontOfQueue.GetType());
                    Console.Write("Visit current node and print its value: " + nodeInFrontOfQueue.data + " ");
                    //currNode = myQ.Dequeue();
                    //Console.WriteLine("Visit current node and print its value: " + currNode.data);



                    if (nodeInFrontOfQueue.left != null)
                    {
                        myQ.Enqueue(nodeInFrontOfQueue.left);
                    }
                    if (nodeInFrontOfQueue.right != null)
                    {
                        myQ.Enqueue(nodeInFrontOfQueue.right);
                    }
                    myQ.Dequeue();
                    Console.WriteLine();
                    Console.WriteLine("No of elements in the queue: {0}", myQ.Count);
               
                }
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
