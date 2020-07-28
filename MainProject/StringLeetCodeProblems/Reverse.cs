using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainProject.StringLeetCodeProblems
{
   public class Reverse
    {
        public void ReverseString(char[] s)
        {
           //taking one pointer as start from starting
            int start = 0;
            //taking another pointer from back side s.length-1
            int end = s.Length - 1;

            //until this condition is true
            while(start<end)
            {
                //swapping the frst elemnet and last element using temp variable
                char temp = s[start];
                s[start] = s[end];
                s[end] = temp;
                //after swapping last elements increasing start from frst elem to scnd
                start++;
                //decresing end to back to last element
                end--;
            }
            
        }
    }
}
