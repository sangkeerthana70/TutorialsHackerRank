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
            queue.AddLast(n);
        }

        // method 4 Dequeuing an item by removing an item at the first index in LinkedList 
        public int Dequeue()
        {
            
            //var objectToInt = Convert.ToInt32(queue);
            return (int)queue.RemoveFirst();
        }

        // peek at the first item in queue
        public int Peek()
        {
            return (int)queue.FirstOrDefault();
        }
        static void Main(string[] args)
        {

        }
    }
}
