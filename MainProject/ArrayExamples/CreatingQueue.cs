using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class CreatingQueue
    {
        //creating 2 stacks
        Stack s1 = new Stack();
        Stack s2 = new Stack();
        public void Enqueue(int x)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            // Push item into s1  
            s1.Push(x);
            // Push everything back to s1
            while (s2.Count > 0)
            {
                s1.Push(s2.Pop());
            }
        }

        public int Dequeue()
        {
            // if first stack is empty  
            if (s1.Count==0)
            {
                Console.WriteLine("Queue is empty");
            }

            //return top of s1
            int x = (int)s1.Peek();
            s1.Pop();
            return x;
        }

    }
}
