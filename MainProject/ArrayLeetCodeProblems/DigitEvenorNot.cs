using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    public class DigitEvenorNot
    {
        public int Even(int[] nums)
        {
           // taking one variable as result and making it as 0
             int result = 0;
            //iterating the array
            for (int i = 0; i < nums.Length; i++)
            {
                //digits will be 0
                int digits = 0;
                //while condition should be satified untiul the condition is true
                //num in the array is not equal to 0
                while (nums[i] != 0)
                {
                    //the num in the array is divided by 10
                    nums[i] = nums[i] / 10;
                    //the count will get increasedr till the num[i]=0 if it is 0 also the digit will get incremenetd and then loop                       //will be break
                    digits = digits + 1;

                }
                //chehcking if the digits remainder is equal to 0
                if (digits % 2 == 0)
                {
                    //then ading the digit into the result
                    result = result + 1;
                }

            }
            //returning the result
            return result;


        }
    }
}
