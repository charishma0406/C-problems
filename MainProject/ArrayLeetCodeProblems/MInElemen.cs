using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class MInElemen
    {
        public int SumOfDigits(int[] A)
        {
            //finidng the min element in the array
            int minelement = int.MaxValue;
            for (int i=0;i<A.Length;i++)
            {
                  if(A[i]<minelement)
                  {
                        minelement = A[i];
                  }

             
            }
            //taking one var as 0
            int result = 0;
            //for adding the number we need to do mod of 10 and divide by 10 and adding to the result
            while(minelement>0)
            {
                //we need to divide the given number with mod 10
                int reminder = minelement % 10;
                //and then add the reminder to the result 
                result = result + reminder;
                //divide the given number and then it will be remove the last decimal numberand again it will check the condition from the mod 10  and it will be ading the result
                minelement = minelement / 10;
            }

            return result;
        }
    }
}
