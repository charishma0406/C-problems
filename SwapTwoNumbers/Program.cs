using System;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, temp;

            Console.WriteLine("first number");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("second number");
            y = int.Parse(Console.ReadLine());

            temp = x;
            x = y;
            y = temp;

            Console.WriteLine("after swaping");
            Console.WriteLine("after swaping first number");
            Console.WriteLine(x);
            Console.WriteLine("after swaping second number");
            Console.WriteLine(y);




           
            


            


          



        

           

        }
    }
}
