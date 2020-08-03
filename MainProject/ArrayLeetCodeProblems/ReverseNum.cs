using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    
    class ReverseNum
    {
        public int Num(int x)
        {
            //taking a long data type beacuse int is not sufficient var as reverse and assign value 0
            long reverse = 0;
            //rotating the loop until the num is not equal to 0
            while (x != 0)
            {
                //num%10 means it will give us reminder
                int reminder = x % 10;
                //if we multiply the reverse  with 10 and adding reminder
                reverse = (reverse * 10) + reminder;
                //diving the number with 10 so that last number will get deleted
                x = x / 10;
                //if the reverse number is greater and less than int.max and in.min value
                if (reverse > Int32.MaxValue || reverse < Int32.MinValue)
                {
                    //returning 0
                    return 0;
                }

            }
            //last converting long to int
            return Convert.ToInt32(reverse);
        }
    }
}
