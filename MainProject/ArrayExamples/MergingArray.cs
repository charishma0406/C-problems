using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class MergingArray
    {
        public void MergeArray()
        {
            //first array
            //creating the length of array
            int[] array1 = new int[4];
            //iterating the values and storing in the array
            for (int i =0;i<array1.Length;i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array1);

            //printing the elements in the array
            for (int i = 0;i<array1.Length;i++)
            {
                Console.WriteLine(array1[i]);
            }

            //2nd array
            int[] array2 = new int[4];

            for(int j =0; j<array2.Length;j++)
            {
                array2[j] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array2);

            //printing the elements in an array

            for(int j= 0; j<array2.Length;j++)
            {
                Console.WriteLine(array2[j]);
            }


            //empty array
            int p = 0;
            int q = 0;
            int[] array3 = new int[8];
            //taking p and q values
            
            //iterating  3rd array
            for(int k=0;k<array3.Length;k++)
            {
                //if first array element is less than 2nd array element
                if( (p<array1.Length && q < array2.Length) && array1[p]<array2[q])
                {
                    //send the p value to 3rd array
                    array3[k] = array1[p];
                    //otherwise increment the p value
                    p++;
                }
                //else if q value is less than p value 
                else if((p < array1.Length && q < array2.Length) && array2[q]<array1[p])
                {
                    //send the q value to array 3
                    array3[k] = array2[q];
                    //otherwise increment q value
                    q++;
                }
                else if(q<array2.Length)
                {
                    array3[k] = array2[q];
                    q++;
                }
                else if(p<array1.Length)
                {
                    array3[k] = array1[p];
                    p++;
                }

                //print 3rd array
                Console.WriteLine(array3[k]);
            }

            
        }
       


    }
}
