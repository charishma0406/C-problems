using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.StringLeetCodeProblems
{
    class Palindrome
    {
        public void Pal(string s)
        {
            
            string result = "";
            for(int i=s.Length-1;i>=0;i--)
            {
                result = result + s[i];
            }

            if(s == result)
            {
                Console.WriteLine("it is palindrome");
            }
            else
            {
                Console.WriteLine("It is not palindrome");
            }
        }
    }
}
