using System;

namespace even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print all the odd numbers from  1 to 100");
            for (int n = 0; n <=100; n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n);
                }
              
                
            }


        }
    }
}
