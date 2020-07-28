using System;

namespace Remove_specified_char
{
    class Program
    {

        public static string Remove_Char(string str, int n )
        {

            //It is removing the char in the string and (n,1) is like the number 1 is count that how many numbers we should delete.
            //For example if we put (n, 2) it will delete  the 2 characters, that we gave the index.
            //for example if index is 3 and if the parameter is 1(3,1) here it will remove the 3rd index and one char
            return str.Remove(n,1);

           
        }
        static void Main(string[] args)
        {

            Console.WriteLine(Remove_Char("w3resource",1));
            Console.WriteLine(Remove_Char("w3resource", 4));
            Console.WriteLine(Remove_Char("w3resource", 0));

        }
    }
}
