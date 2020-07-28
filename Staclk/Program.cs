using System;
using System.Collections;

namespace stk
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push(3);
            stk.Push(2);
            stk.Push(1);
            
          foreach(Object obj in stk)
            {
                Console.WriteLine(obj);
            }
            // stk.Pop();



        }
    }
}
