using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class Max2Arrays
    {
        public int MaxProduct(int[] nums)
        {
            //taking the variable as max to find the product of max values
            int max = int.MinValue;
            //iterating the array from i =0
            for (int i = 0; i < nums.Length; i++)
            {
                //iterating the array from j=0 and if j<i then it will continue
                for (int j = 0; j < i; j++)
                {
                    //product of 2 max numbers 
                    int produt = (nums[i] - 1) * (nums[j] - 1);
                    //if product is greater than the max
                    if (produt > max)
                    {
                        //then max will replace with product value
                        max = produt;
                    }
                }

            }
            //return max
            return max;
        }
    }
}
