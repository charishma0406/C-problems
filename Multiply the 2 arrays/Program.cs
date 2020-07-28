using System;

namespace Multiply_the_2_arrays
{
    class Program
    {
        static void Main(string[] args)
        {

             int[] array1 = {1,3,-5,4};
             int[] array2 = {1,4,-5,-2};
           
            //iterating each and every num in the frst array it will check the length and it will go to loop and multiply array[0] * array[0]
            for(int i = 0; i<array1.Length;i++)
            {
                //1,12,25,-8
                Console.WriteLine(array1[i]*array2[i]);
            }




        }
    }
}
