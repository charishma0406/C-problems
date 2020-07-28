using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class SumArray
    {
        public void SumOfArray()
        {
            //length of the array
            int[] sumarray = new int[3];
            int sum = 0;

            //giving the values of an array
            for(int i=0;i<sumarray.Length;i++)
            {
                sumarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            //for printing
            for(int i=0;i<sumarray.Length;i++)
            {
                 sum += sumarray[i];
            }

                Console.WriteLine(sum);
        }
    }
}
