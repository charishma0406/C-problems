using System;

namespace Enter_2_intergers
{
    public static class Program
    {


        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());

            int y = int.Parse(Console.ReadLine());

            //Console.WriteLine((x>0 && y<0) || (x<0 && y>0));
            if(x>0 && y<0)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
