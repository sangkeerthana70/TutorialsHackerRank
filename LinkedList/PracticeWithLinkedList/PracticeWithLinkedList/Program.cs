using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWithLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = Node.InsertNodeToTail(head, data);
            }
            Node.display(head);
        }



        public class Node
        {
            int data;
            Node next;

            public Node(int d)
            {
                this.data = d;
                this.next = null;
            }

            public static Node InsertNodeToTail(Node head, int data)
            {
                Console.WriteLine("In Insert method");
                Node myNode = new Node(data);

                if(myNode.next == null)
                {
                    return myNode;
                }

                Node currNode = head;
                while(currNode.next != null)
                {
                    
                    currNode = currNode.next;
                    Console.WriteLine("currNode: " + currNode);
                }
                currNode.next = myNode;

                return head;

            }

            public static void display(Node head)
            {
                Console.WriteLine("In display method");

                //Node start = head;
                while (head != null)
                {
                    Console.Write(head.data + " ");
                    head = head.next;
                    
                }
            }
        }
    }
}
