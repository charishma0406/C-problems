using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class Shuffle
    {
        public int[] Shuff(int[] nums, int n)
        {

            //taking an empty array
            int[] result = new int[nums.Length];
            //taking variables as int 1=0, and given n=3 so we need to start j from n and k=0 for iterating the result array
            int i = 0, j = n, k = 0;
            //until the condition is true
            while (k < result.Length && i < nums.Length)
            {
                //result = nums[i]
                result[k] = nums[i];
                //increment i
                i++;
                //increment k
                k++;
                //result = nums[j]
                result[k] = nums[j];
                //increment i
                j++;
                //increment k
                k++;
            }
            return result;

        }
    }
}
