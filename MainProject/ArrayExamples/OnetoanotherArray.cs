using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class OnetoanotherArray
    {
        public void OtoT()
        {
            int[] array = new int[4];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            

            int[] array1 = new int[4];

            for(int i=0;i<array1.Length;i++)
            {
                array1[i] = array[i];
            }

            for(int i =0;i<array1.Length;i++)
            {
                Console.WriteLine(array1[i]);
            }
        }
        

    }
}
