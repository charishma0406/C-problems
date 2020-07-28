using System;

namespace Diff_and_double
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());

            int difference = x1 - y1;

            if(x1 > y1)
            {
                difference = difference * 2;
            }
            Console.WriteLine(difference);
        }
    }
}
