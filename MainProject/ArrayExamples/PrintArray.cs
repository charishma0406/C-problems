using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject
{
    public class PrintArray
    {
        public void PrintArrayElements()
        {
            //for input and output

            /*//size of an array
            int[] arr = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                //giving values in an array
                arr[i] = Convert.ToInt32(Console.ReadLine());
            
            }

            //printing values in and array
           for(int i = 0; i<10;i++)
            {
                Console.Write(arr[i]);
            }
              */

            //if we are giving directly the numbers in the program 

            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
