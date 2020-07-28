using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    class NextGreatestElement
    {
        public void Greatest(int[] array)
        {
            //iterating the array from frst element
            for (int i = 0; i < array.Length; i++)
            {
                //taking the var as -1 freshly
                int next = -1;
                //itereating the elemenet from next to the array[i]
            for (int j=i+1;j<array.Length;j++)
            {
                    //if array[i]element is less than array[j]element
                    if(array[i]<array[j])
                    {
                        //replace next with that array[j]element
                        next = array[j];
                        //if it is greater then break
                        break;
                    }
            }
            //print the array[i] element and next element
                Console.WriteLine(array[i]+ " "+ next);
            }
           
        }
    }
}
