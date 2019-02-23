﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWithStacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.push(5);
            s.push(10);
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
        }

        private class Stack
        {
            private List<int> stack;
            public Stack()
            {
                this.stack = new List<int>();
            }

            public void push(int n)
            {
                stack.Add(n);
                Console.WriteLine("In push method");
                foreach(var num in stack)
                {
                    Console.WriteLine("num in List: " + num);
                }
                
                
                
            }

            public int pop()             
            {
                Console.WriteLine("In Pop method");
                Console.WriteLine(stack.Count);
                
                int lastElement = stack.Last();
                Console.WriteLine("lastElement: " + lastElement);
                stack.RemoveAt(stack.Count - 1);
                Console.WriteLine(stack.Count);
                foreach (var num in stack)
                {
                    Console.WriteLine("num in List: " + num);
                }

                return lastElement;
            }
        }

        

        
    }
}
