using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Queuey
    {
        // declare LinkedList as the property
        LinkedList<int> queue;
        // constructor
        public Queuey()
        {
            // instantiate the LinkedList object here
            queue = new LinkedList<int>();
        }

        // method 1 check if our queue is empty
        public bool IsEmpty()
        {
            if(queue.First == null)
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
            return queue.Count;
        }

        // method 3 Enqueuing an item by adding the int to the tail of the LinkedList
        public void Enqueue(int n)
        {
            Console.WriteLine("LinkedList after adding a node...");
            queue.AddLast(n);
            foreach (var num in queue)
            {
                Console.WriteLine(num);
            }
        }

        // method 4 Dequeuing an item by removing an item at the first index in LinkedList 
        public int Dequeue()
        {

            //var objectToInt = Convert.ToInt32(queue);
           
            Console.WriteLine("LinkedList after removing a node...");
            queue.RemoveFirst();
            foreach (var num in queue)
            {
                Console.WriteLine(num);
            }
            return 0;
        }

        // peek at the first item in queue
        public int Peek()
        {
            return (int)queue.FirstOrDefault();
        }



        static void Main(string[] args)
        {
            Queuey numberQueue = new Queuey();
            numberQueue.Enqueue(5);
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(11);
            numberQueue.Dequeue();
            Console.WriteLine("Peek at second item in queue " + numberQueue.Peek());
            numberQueue.Dequeue();
            numberQueue.Dequeue();
            Console.WriteLine("======================================");
            StringQueue stringQueue = new StringQueue();
            stringQueue.Enqueue("Hi");
            stringQueue.Enqueue("there");
            stringQueue.Enqueue("how");
            stringQueue.Enqueue("are");
            stringQueue.Enqueue("you");
            stringQueue.Dequeue();
            Console.WriteLine("Peek at second item in queue " + stringQueue.Peek());
            stringQueue.Dequeue();
            stringQueue.Dequeue();

        }
    }
}
