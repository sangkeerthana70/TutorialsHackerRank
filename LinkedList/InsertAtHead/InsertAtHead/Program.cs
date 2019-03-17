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

            var linkedList = CreateLinkedList(intList);
        }

        public static ListNode<int> CreateLinkedList(List<int> intList)
        {
            ListNode<int> head = new ListNode<int>();

            var currNode = head;

            for(var i = 0; i < intList.Count; i++)
            {
                currNode.value = intList[i];
               
                if(i < intList.Count -1)
                {
                    // create next node 
                    currNode.next = new ListNode<int>();
                    Console.WriteLine("currNode: " + currNode.value);
                    
                    currNode = currNode.next;
                    

                }
                
            }
            return head;
        }


    }

    
}
