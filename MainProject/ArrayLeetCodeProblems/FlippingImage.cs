using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class FlippingImage
    {
        public int[][] FlipAndInvertImage(int[][] matrix)
        {
            //iterating the matrix
            for(int i=0;i<matrix.Length;i++)
            {
                //taking only single row
                int[] array = matrix[i];
                //taking an empty array
                int[] resultarray = new int[array.Length];
                //for reversing taking k=0 for filling the empty array
                int k = 0;
                //iterating the array from back side
                for(int j = array.Length-1;j>=0;j--)
                {
                    //giving the values from backside into the empty array
                    resultarray[k] = array[j];
                    //and increasing k beacuse we need to store the values in the array
                    k++;

                }
                //replacing the matrix with the reversing array result array
                matrix[i] = resultarray;
            }
          
            //iterating the rows and columns in the matrix and replacing them with 0 and 1
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix.Length; column++)
                {
                    if (matrix[row][column] == 1)
                    {
                        matrix[row][column] = 0;
                    }
                    else if (matrix[row][column] == 0)
                    {
                        matrix[row][column] = 1;
                    }
                }
            }

            //returning the matrix
            return matrix;
        }
    }
}
