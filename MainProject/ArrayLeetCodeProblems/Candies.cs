using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    public  class Candies
    {
        public void KidsCandies()
        {
            //creating an candies array
            int[] candies = new int[5] { 2, 3, 5, 1, 3 };
            //extracandies is 3
            int extracandies = 3;
            //to find the largest number taking largest number as 0
            int largest = 0;
            //iterating each an every element in an array
            for (int i = 0; i < candies.Length; i++)
            {
                //chechkng this condition if candies[i] is greater than my largest number it will chechk with each and every element
                if(candies[i]>largest)
                {
                    //then my largest number should be the candies[i]
                    largest = candies[i];

                }
               
            }

            //taking bool array to check the answer is true or false
            //bool[] result = new bool[5];
            List<bool> result = new List<bool>();
            //iterating each and every element  
            for (int i=0;i<candies.Length;i++)
            {
                //adding the elemnets in the array with my extracandies and checking if it is greater or not
                if(candies[i]+extracandies >= largest)
                {
                    //if it is greatest then result is true
                    //result[i] = true;
                    result.Add(true);
                }
                
                else
                {
                    //else my result is false
                    //result[i] = false;
                    result.Add(false);
                }

            }
           // printing the array
            for(int i=0;i<result.Count;i++)
            {
                //Console.WriteLine(result[i]);
                Console.WriteLine(result[i]);
            }


           
            

            
        }
    }
}
