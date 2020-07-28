using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    public class SmallNumbers
    {
        public int[] Small(int[] nums)
        {
            //taking another empty array and it should be nums.length
            int[] result = new int[nums.Length];

            //iterating each and every element in an array
            for(int i=0;i<nums.Length;i++)
            {
                //taking count as 0, y we are taking it here beacuse the count should get refresh everytime as 0 for eah element
                int count = 0;

                //for comparison we are taking this for loop
                for(int j=0;j<nums.Length;j++)
                {
                    //if num[j]<num[i]
                    if(nums[j]<nums[i])
                    {
                        //then we are increasing the count
                        count++;
                    }
                   
                }
                //after the count got incremented then we are saving that count in our result array
                //before count becomes 0 we are saving each element in the array like frst number count will be 4 then it will save in the array then next number
                result[i] = count;
            }

            //returning the result
            return result;





        }

       

       
    }
      
    }

