using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class PrintReverseArray
    {
        public void ReverseArray()
        {
            int[] array = new int[3];

            for(int i =0;i<array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i= array.Length-1;i>=0;i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
