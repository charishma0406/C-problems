using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class RunningSum
    {
        public int[] Running(int[] nums)
        {

            //we can do it in this way also
            for (int i = 1; i < nums.Length; i++)
            {
                //replacing the in the num[i] and adding nums[i]+nums[i-1] elements
                nums[i] = nums[i] + nums[i - 1];
            }
            return nums;


            /*//this is another approach 2nd approach
             
            //taking the sum as variable to store the frst value from the array
            int sum = 0;
            //for iterating the resultarray we are taking the j=0

            //taking an empty array 

            //iterating each and every element in the array
            for (int i = 0; i < nums.Length; i++)
            {
                //taking the sum plus the element in the array and storing in sum var. sum var will be replaced with fresh number after adding and if will get added to the fresh number
                sum = sum + nums[i];
                //putting the sum into the array after adding
                nums[i] = sum;

            }
            return nums;



            //we can do it in this way also third approach
            /*int sum = 0;
            int j = 0;
            int[] result = new int[nums.Length];

            for(int i=0;i<nums.Length;i++)
            {
                sum = sum + nums[i];
                result[j] = sum;
                j++;

            }
            return result;*/



        }  
    }
  }

