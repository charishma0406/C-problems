using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class greatestelement
    {
        public int[] Replace(int[] array)
        {
            //iterating the array
            for (int i = 0; i < array.Length; i++)
            {
                //finiding the greatest element taking int.minvalue
                int greatest = int.MinValue;
                //iterating from the second element in the array
                for (int j = i + 1; j < array.Length; j++)
                {
                    //checkng if the scnd element in the array is greater than greatest element 
                    if (array[j] > greatest)
                    {
                        //then greatest will become arra[j] element
                        greatest = array[j];
                    }
                    //then replacing the array[i] element with the greatest elem
                    array[i] = greatest;
                }

            }
            //if the last number arrives then return -1
            array[array.Length - 1] = -1;

            return array;

        }
    }
}
