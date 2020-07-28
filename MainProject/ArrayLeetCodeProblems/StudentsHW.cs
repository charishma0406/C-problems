using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    public class StudentsHW
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            //taking count as 0
            int count = 0;
            //checking the lengths of the 2 arrays
            if (startTime.Length == endTime.Length)
            {
                //iterating the array
                for (int i = 0; i < startTime.Length; i++)
                {
                    //checkng the condition if fist elem in the frst array is less tahn or equal to querytime and the querytime is less than or equal to the second array
                    //chehckng the both conditions is true
                    if (startTime[i] <= queryTime && queryTime <= endTime[i])
                    {
                        //then only increasing the count
                        count++;
                    }
                }
                
            }
            //return the count
            return count;

        }

    }
}

