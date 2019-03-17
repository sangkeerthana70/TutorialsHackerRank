using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertAtHead
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 3, 1, 2, 3, 4, 5 };

            var firstNode = CreateLinkedList(intList);
            Console.WriteLine("result: " + firstNode.value);

            ListNode<int> l = new ListNode<int>();
            int lvalue = l.value;
            lvalue = 10;
           
            var insertList = InsertNodeAtHead(lvalue , firstNode);
            Console.WriteLine("res of insertList: " + insertList.value);
        }

        public static ListNode<int> CreateLinkedList(List<int> intList)
        {
            Console.WriteLine("In create Linked List method");
            ListNode<int> head = new ListNode<int>();

            var currNode = head;

            for(var i = 0; i < intList.Count; i++)
            {
                currNode.value = intList[i];
               
                if(i < intList.Count -1)
                {
                    // create next node 
                    currNode.next = new ListNode<int>();
                    //Console.WriteLine("currNode before switching: " + currNode.value);
                    
                    currNode = currNode.next;
                    //Console.WriteLine("currNode after switching: " + currNode.value);

                }
                
            }
            return head;//returns head Node
        }

        public static ListNode<int> InsertNodeAtHead(int lvalue, ListNode<int> firstNode)
        {

            ListNode<int> insertNode = new ListNode<int> { };
            
            insertNode.value = lvalue;
            insertNode.next = firstNode;
            Console.WriteLine("insertNode.next: " + insertNode.next.value);

            return insertNode;
        }

    }

    
}
