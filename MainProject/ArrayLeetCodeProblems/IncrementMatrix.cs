using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class IncrementMatrix
    {
        public int Odd(int n, int m, int[][] indices )
        {
            //talikng one array as row
            int[] rows = new int[n];
            //taking one array as coloumn
            int[] coumns = new int[m];

            //iterating the for loop for theindices
            for (int i = 0; i < indices.Length; i++)
            {
                    //we are iterating the row 
                    rows[indices[i][0]]++;
                //we are iteratingthe coloumn
                    coumns[indices[i][1]]++;

                
            }

            //taking the oddcount as 0 
            int oddcount = 0;
            //iterating the orws 
            for(int i=0;i<rows.Length;i++)
            {
                //iterating the columns
                for(int j=0;j<coumns.Length;j++)
                {
                    //adding rows and columns because we need to check the odd numbers in the matrix
                    if(rows[i]+coumns[i] %2!=0)
                    {
                        //increasing the odd count.
                        oddcount++;
                    }
                }
            }
            //return the odd count
            return oddcount;
            }
        }
    }

