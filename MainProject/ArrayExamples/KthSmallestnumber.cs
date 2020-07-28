using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class KthSmallestnumber
    {

        public int KthSmallest(int[] array, int k)
        {
            //if the kth element is not smallest than array return 0
            //sorting the array
            Array.Sort(array);

            //returning kth element in the sorted array why we are putting as k-1 is beacuse we should check with index so the index starts from 0 so we need to make it as k-1
            return array[k-1];
        }
    }
}
