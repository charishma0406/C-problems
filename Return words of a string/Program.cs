using System;

namespace Return_words_of_a_string
{
    class Program
    {
        static void Main(string[] args)
        {


            string str = "My name is Charishma";
            string[] array = str.Split(" ");
            string result = " ";

            for(int i = str.Length-1;i >=0;i--)
            {
                result = result + str[i];
            }
            Console.WriteLine(result);

        }
    }
}
