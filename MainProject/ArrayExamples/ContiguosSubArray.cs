using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
   public class ContiguosSubArray
    {
        public int ContigousSubArray(int[] a)
        {
            //kandane's algorithm
            //we are declaring as int.min value because for both +ve and -ve numbers we can verfiy this alogrthm
            int max_so_far = int.MinValue;
            int max_ending_here = 0;
            int size = a.Length;

            //interating
            for (int i=0;i<size;i++)
            {
                max_ending_here = max_ending_here + a[i];

                if(max_so_far<max_ending_here)
                {
                    max_so_far = max_ending_here; 
                }
                if(max_ending_here<0)
                {
                    max_ending_here = 0;
                }

               

            }
            return max_so_far;

        }
        

    }
}
