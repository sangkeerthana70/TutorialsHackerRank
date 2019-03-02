using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myLinkedList = new LinkedList<int>();

            // Add a node with data=25 to back of the (empty) list
            myLinkedList.AddLast(25);

            myLinkedList.AddLast(30);
            // Insert a node at front of the list
            myLinkedList.AddFirst(20);
            //Insert a node with data = 30 at back of the list
            myLinkedList.AddLast(35);
            // // Insert a node with data="15" at index 2

            var currentNode = myLinkedList.First;
            Console.WriteLine("curr node: " + currentNode.Value);
            while(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                Console.WriteLine("currentNode value: " + currentNode.Value);
            }
            
        }
    }
}
