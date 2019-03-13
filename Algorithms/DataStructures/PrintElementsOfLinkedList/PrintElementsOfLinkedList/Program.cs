using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintElementsOfLinkedList
{
    class Program
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;

            }

            static void printLinkedList(SinglyLinkedListNode head)
            {
               
                var currNode = head;
                Console.WriteLine(currNode.data);
                while (currNode != null)
                {
                    if(currNode.next == null)
                    {
                        break;
                    }
                    else
                    {
                        currNode = currNode.next;
                        Console.WriteLine(currNode.data);
                    }
                    
                    
                }
 

            }


            static void Main(string[] args)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                printLinkedList(llist.head);

            }
        }

    }
}
    

