using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class MinMax
    {
        public double Salary(int[] salar)
        {
            //taking the var as sum and making it as 0 for adding all the values in the arry to find the average . average formula adding total num of elemnet divided by total num of elem
            double sum = 0;
            //for min value taking min var
            int min = int.MaxValue;
            //for max value taking max var
            int max = int.MinValue;
            //iteratinhg each and every element in the array
            for (int i = 0; i < salar.Length; i++)
            {
                //finidng the min value and adding it to min var
                if (salar[i] < min)
                {
                    min = salar[i];

                }
                //finiding the max value and adding it to the max var
                if (salar[i]>max)
                {
                    max = salar[i];
                }
                //
                sum = sum + salar[i];
             }

            //finiding the min and max value and we are minising from the sum those 2 values
            sum = sum - min - max;
            //other than min and max value we need to find the avg for all the other element so we are doing like this, finiding min and max and adding all the elem in the arry and then sum divide by array.leng -2
            double avg = sum / (salar.Length - 2);

            return avg;
        }
        
    }
    
}
