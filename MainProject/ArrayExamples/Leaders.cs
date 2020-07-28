using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class Leaders
    {
        public void Leader(int[] array, int size)
        {
            for(int i =0;i<size;i++)
            {
                int j;
                for( j=i+1;j<size;j++)
                {
                    if(array[i]<=array[j])
                    {
                        break;
                    }
                    
                }
                if (j == size)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

    }
}
