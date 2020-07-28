using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.StringLeetCodeProblems
{
    class RemoveVowels
    {
        public string Vowels(string s)
        {
            //taking result as null 
            string result = "";
            //creating dictionary key and value as char and bool
            Dictionary<char, bool> dict = new Dictionary<char, bool>();
            //adding the vowels into the dict
            dict.Add('a', true);
            dict.Add('e', true);
            dict.Add('i', true);
            dict.Add('o', true);
            dict.Add('u', true);

            //iterating the each element in the string
            for (int i=0;i<s.Length;i++)
            {
                //if the dict doesnot contain the element
                if(!dict.ContainsKey(s[i]))
                {
                    //ad the element to the result
                    result = result + s[i];
                }
            }
            //retrurn result
            return result;
        }
    }
}
