using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class StringtoInt
    {
        public int StringtoIn(string str)
        {
            //taking int i=0
            int i = 0;
            //taking result as variable and making it as 0
            int result = 0;
            //taking the sign as variable because if the frst char of the string, frst we are taking sign as positive if teh frst char is neg then we can change the sign as -1
            int sign = 1;

            //checkng the condition if the frst char of my string is negative means then making my sign as -1
            if (str[0] == '-')
            {
                sign = -1;
                //if it is starts with - then increse the i value
                i++;
            }
            //iterating each and every char in the string
            for (; i < str.Length; i++)
            {
                //there will be some ascii values
                //taking the current number as frst char in the string minus the ascii value 0 as 90. 0=90. if str[i] char is 1 the ascii value is 91 then the 0 ascii value is 90 so 91-90 = 1 
                int currentnumber = str[i] -'0';
                //then my result will be 
                //if we do the result *10 -currentnum then our result will come.
                //initially my result = 0 *10 + 1 = 0+1 =1
                result = result * 10 + currentnumber;
                

            }
            //returning the sign multiplied with  result 
            return sign * result;

        }

    }
}
