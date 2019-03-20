using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class StringQueue
    {
        LinkedList<string> stringQueue;
        public StringQueue()
        {
            stringQueue = new LinkedList<string>();
        }

        // method 1 check if our queue is empty
        public bool IsEmpty()
        {
            if (stringQueue.First == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // method 2 check size of queue
        public int Size()
        {
            return stringQueue.Count;
        }

        // method 3 Enqueuing an item by adding the int to the tail of the LinkedList
        public void Enqueue(string n)
        {
            Console.WriteLine("LinkedList after adding a node...");
            stringQueue.AddLast(n);
            foreach (var word in stringQueue)
            {
                Console.WriteLine(word);
            }
        }

        // method 4 Dequeuing an item by removing an item at the first index in LinkedList 
        public string Dequeue()
        {

            //var objectToInt = Convert.ToInt32(queue);

            Console.WriteLine("LinkedList after removing a node...");
            stringQueue.RemoveFirst();
            foreach (var word in stringQueue)
            {
                Console.WriteLine(word);
            }
            return "";
        }

        // peek at the first item in queue
        public string Peek()
        {
            return (string)stringQueue.FirstOrDefault();
        }


    }
}
