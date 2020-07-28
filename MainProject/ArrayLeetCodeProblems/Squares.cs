using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class Squares
    {
        public int[] Square(int[] array)
        {
            int[] resultarray = new int[array.Length];
            for(int i=0;i<array.Length;i++)
            {

                resultarray[i] = array[i] * array[i];
            }
            Array.Sort(resultarray);
            return resultarray;
        }
        
    }
}
