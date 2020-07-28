using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class MissingNumbers
    {
        public int  Missing(int[] array, int n)
        {
            //formula is (n(n+1))/2
            //the length of the array with the missing number is 5 but in the array it shows only{1,2,3,5} if we include 4 the length is 5
            int result = ((n + 1) * (n + 2)) / 2;
            //iterating each value int the array and verifying
            for(int i =0;i<n;i++)
            {
                //subtarcting result - missing element
                result = result - array[i];
            }
            return result;

        }
    }
}
