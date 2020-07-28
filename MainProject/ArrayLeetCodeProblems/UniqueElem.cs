using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class UniqueElem
    {
        public int[] SumZero(int n)
        {
            //for getting the rndom values in tha array we are using Random inbuilt class and creating thje object
            Random randomobj = new Random();
           //taking one empty array
            int[] array = new int[n];
            //taking the var as size and dividing with 2 because we need to know if it is even or odd
            int size = n / 2;
            //iterating the array and adding the values randomly in the array
            for(int i=0;i<size;i++)
            {
                //adding the values in the array  using int.minvalue and int.max value
                array[i] = randomobj.Next(int.MinValue,int.MaxValue);
            }
            //taking the var as second and taking as 0
            int second = 0;
            //if the n value is even
            if (n % 2 == 0)
            {
                //the second value will be array.length no need of adding the 0 value in the last
                second = array.Length;
            }
            else
            {
                //else if the n value is odd the second value will be array.length-1 no need of adding the 0 value in the last
                second = array.Length - 1;
            }
            //taking another var k=0
            int k = 0;
            //iterationg from the 3 rd element in the array that is from the size of the array
            for (int j = size; j < second; j++)
            {
                //adding the opposite values into the array
                array[j] = -1 * array[k];
                //and then moving to the next variable
                k++;
            }
            //returning the array
            return array;
           
        }
    }
}
