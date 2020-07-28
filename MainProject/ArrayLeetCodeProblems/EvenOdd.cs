using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class EvenOdd
    {
        public int[] SortArrayByParity(int[] array)
        {

            int j = 0;
            int[] newarray = new int[4];
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]%2 == 0)
                {
                    newarray[j] = array[i];
                    j++;
                }
            }
            
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]%2 == 1)
                {
                    newarray[j] = array[i];
                    j++;
                }
            }
            return newarray;


        }
    }
}
