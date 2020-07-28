using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class ToLowerCaseUsingASCII
    {
        public string ToLowerV(string str)
        {
            //converting string into array
            char[] arr = str.ToCharArray();
            //iterating each and every char in the given string
            for(int i =0;i<arr.Length;i++)
            {
                //checkng the condition that if the frst char in the string is greater than the A char in the ascii values and les than the Z in the ascii values
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    //then subtracting the current value in the string with A in ascii value and adding it with small a beacuse if we subtract the current 
                    //value with A then the disctnce btw small 'a' will aslo be the same for the current value
                    arr[i] = Convert.ToChar(arr[i] - 'A' + 'a');
                }
            }
            //convert the array into the string and return it
            return(new string(arr));

        }
    }
}
