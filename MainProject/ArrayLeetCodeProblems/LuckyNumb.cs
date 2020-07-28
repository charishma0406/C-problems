using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    public class LuckyNumb
    {
        //taking one method and return type list because we dont know how many numbers will be  there
        public List<int> Lucky(int[][] matrix)
        {
            //creating new list
            List<int> result = new List<int>();
            //taking the rows as matrix.length becuase if we check the length we will know how many rows are there
            int totalrows = matrix.Length;
            //if we check the length of the frst row we will know how many columns are there in a matrix so matrix[0] means frst row in the matrix
            int totalcol = matrix[0].Length;
            //gathering all the minimum values into the array frm the rows
            int[] rowmins = new int[totalrows];
            //gathering all the maximum values into the array from columns
            int[] colummax = new int[totalcol];

            //iterating the first row 
            for (int row = 0; row < totalrows; row++)
            {
                //taking the min var locally 
                int minimum = int.MaxValue;
                //iterating all the columns in the frst row
                for (int column = 0; column < totalcol; column++)
                {
                    //checkng the condition if the number in the matrix is less than min value or not. and then min value will change and it will check with that min value
                    if (matrix[row][column] < minimum)
                    {
                        //add the all the min values to the minimum
                        minimum = matrix[row][column];
                    }

                }
                //adding all the min values to the row array
                rowmins[row] = minimum;
            }

            //iterating the oth column frst and 
            for (int column = 0; column < totalcol; column++)
            {
                //taking as max var
                int maximum = int.MinValue;
                //iterating all the rows from frst column to last column
                for (int row = 0; row < totalrows; row++)
                {
                    //check the condition if greater than max or not
                    if (matrix[row][column] > maximum)
                    {
                        //adding all the max values from the matrix 
                        maximum = matrix[row][column];
                    }
                }
                //add all the values max values to the column array
                colummax[column] = maximum;
            }

            //iterating each rows and columns 
            for (int i = 0; i < rowmins.Length; i++)
            {
                for (int j = 0; j < colummax.Length; j++)
                {
                    //check the elements in the rows array and elements in the column array if both are equal 
                    if (rowmins[i] == colummax[j])
                    {
                        //add row or column to the resut
                        result.Add(rowmins[i]);
                    }
                }

            }
            //return result
            return result;
        }
    }
}
