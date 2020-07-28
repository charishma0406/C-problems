using System;

namespace Longest_word_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //giving the string 
             string str = "My name is Charishma";
             string longest = " ";
             int len = 0;
             //splitting the string by space
              string[] array = str.Split(" ");
             //giving the sentence in the array
            string[] array1 = {"My", "name", "is", "Charishma" };

             //iterating each and every word in the array
             for(int i = 0;i<array1.Length;i++)
             {
                 string temp = array1[i];
                 //if the word of the lenght is greater than the 0
                 if(temp.Length>len)
                 {
                     //putting the latest word in the temp
                     longest = temp;
                     //and if latestlen = temp.lenght
                     len = temp.Length; 
                 }

             }
             //print longest
             Console.WriteLine(longest);*/


            string stri = "I love you Chetu";
            string[] array = stri.Split(" ");
            string longestword = " ";
            int length = 0;

            string[] array1 = {"I", "Love", "You", "Chetu"};
            
            for(int i = 0; i<array1.Length;i++)
            {
                string var = array1[i];
                if(var.Length>length)
                {
                    longestword = var;
                    length = var.Length;               
                }
            }
            Console.WriteLine(longestword);

        }
    }
}
