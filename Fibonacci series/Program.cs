using System;

namespace Fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {


            //fibonacci series is like adding 2 numbers and getting the 3rd number
            //eg: 0 1 2 3 (0+1=1, 1+2=3, 2+3 = 5)
            //so the fibonacci series result is 1,3,5
            
            int a = 0,
                b = 1,
                c;

            Console.WriteLine("Pleas eenter the number");

            int z = Int32.Parse(Console.ReadLine());

            Console.WriteLine(a+" "+b);
            for(int i = 2; i<z;i++)
            {
                c = a + b;

                Console.WriteLine(c);
                a = b;
                b = c;
            }





        }
    }
}
