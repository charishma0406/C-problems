using System;

namespace Summ_of_triple_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int sum = x1 + y1;

            if(x1 == y1)
            {
                sum = 3 * sum;
            }

            Console.WriteLine(sum);
        }
    }
}
