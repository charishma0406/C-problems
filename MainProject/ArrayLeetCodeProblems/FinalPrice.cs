using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class FinalPrice
    {
       public void Final(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if(array[j]<array[i])
                    {
                        array[i] = array[i] - array[j];
                        break;
                    }
                }
                
            }
           
        }
         
    }
}
