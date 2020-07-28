using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class Arthmetic_progression
    {
        public bool CanMakeArthmeticProgression(int[] arr)
        {
            //sort an array
            Array.Sort(arr);
            //first we need to check the difference btw frst num and scnd num
            int difference = arr[1] - arr[0];
            //iterating each element
            for (int i = 1; i < arr.Length; i++)
            {
                //checkng the diff with each elem and checkng with diff
                if (arr[i] - arr[i - 1] != difference)
                {
                    //if not equal return false
                    return false;
                }

            }
            //if equal return true
            return true;
        }
    }
}
