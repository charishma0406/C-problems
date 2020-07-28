using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class SortParity2
    {
        
        public int[] Parity(int[] array)
        {
            //taking new array
            int[] result = new int[array.Length];
            //for starting index we are taking j =0; and for odd taking another var k=1
            int j = 0;int k = 1;
            //for iteration using for loop
            for(int i=0;i<array.Length;i++)
            {
                //checkng the condition is even
                if(array[i]%2 ==0)
                {
                    //if even sending the element to new array with j=0 ecause from frst onwards we need to start
                    result[j] = array[i];
                    //incrementing j = j+2; for even index
                    j = j + 2;
                }
                else
                {
                    //starting from frst index becasue it is odd storing from frst index if it is odd
                    result[k] = array[i];
                    //increasing k value k+2
                    k = k + 2;
                }
                 
            }
            //return result array
            return result;


        }
    }
}
