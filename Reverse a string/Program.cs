using System;

namespace Reverse_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "cherry";
           
            string rev = "";
            for(int i=str.Length-1;i>=0;i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);
        }
    }
}
