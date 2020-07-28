using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    public class Negativenumbers
    {
        public int Negative(int[][] grid)
        {
            //taking the grid as row
            int m = grid.Length;
            //taking this as column. why we re taking as grid[0] because if we take the length of the frst 0 column.length means the column legth will come
            int n = grid[0].Length;
            //counting the negative numbers
            int negativenumbers = 0;
            //total count of coulmns
            int totalcount = n;

            //iterating for the row
            for (int row = 0; row < m; row++)
            {
                //iterating for the column
                for (int column = 0; column < n; column++)
                {
                    //checkng the condition if it is less than 0
                    if (grid[row][column] < 0)
                    {
                        //if we do minus from the total number of coumns(totalcount) - the specified column where the negative number is located 
                        //eg: columns = 4 -if it is oth column then 4-0 = 4 all the 4 columns are having negative numbers
                        //4-1 =3 all the three columns are having the negative numbers
                        negativenumbers = negativenumbers + (totalcount - column);
                        //if the column have the ngeative number break otherwise continue the loop
                        break;
                    }

                }

            }
            //return the negative numbers 
            return negativenumbers;
        }
    }
}
