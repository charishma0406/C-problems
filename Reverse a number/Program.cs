using System;

namespace Reverse_a_number
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            int reversenumber = 0;

            while(number!=0)
            {
                int remainder = number % 10;
                reversenumber = (reversenumber * 10) + remainder;
                number = number / 10;


            }
            Console.WriteLine(reversenumber);



        }
    }
}
