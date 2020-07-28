using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class EncodingList
    {

        public int[] Encoding(int[] nums)
        {
            //creating a list because we don't know how many elements we need to ad in the array
            List<int> result = new List<int>();
            //iterating an array 
            //taking i=1 beacuse we need to chechk the value and i =i+2 because wee need to mve to next to next numb
            for (int i = 1; i < nums.Length; i = i + 2)
            {
                //taking the var as value is num[i] in the array
                int value = nums[i];
                //taking the fq as i-1 because fq is left to the value
                int frequeny = nums[i - 1];
               // using this for loop to just iterate the j value with fq
                for (int j = 0; j < frequeny; j++)
                    {
                        //and adding that value in the list
                        result.Add(nums[i]);
                    }

            }
            //converting the list into array and returning that
            return result.ToArray();


        }
        
    }
}
