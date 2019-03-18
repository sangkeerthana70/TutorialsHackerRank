﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNodeAtHeadOfLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList llist = new SinglyLinkedList();
           

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, llistItem);
                llist.head = llist_head;
                PrintSinglyLinkedList(llist.head);
                //Console.WriteLine("llist.head.value: " + llist.head);
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

        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node)
        {
            Console.WriteLine("in print");
            while (node != null)
            {
                var currNode = node;
                if (currNode.next == null)
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


        // Complete the insertNodeAtHead function below.

        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */
        static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
        {
            Console.WriteLine("In Insert");

            if(llist == null)
            {
                return llist;
            }

            var currNode = llist;
            while(currNode != null)
            {
                currNode.data = data;
                currNode = currNode.next;
                Console.WriteLine("currNode.data: " + currNode.data);
            }

            return llist;

        }
    }
}
