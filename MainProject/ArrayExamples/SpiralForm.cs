using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class SpiralForm
    {

        public void SpiralPrint(int[][] matrix)
        {


            int rowstart = 0;
            int rowend = matrix.Length-1;
            int columnstart = 0;
            int columnend = matrix.Length-1;

            while(rowstart <= rowend && columnstart<= columnend)
            {
                //printing the first row in the matrix
                for(int i = columnstart; i<=columnend;i++ )
                {
                    Console.WriteLine(matrix[rowstart][i]);
                }
                //moving the row from first to second
                rowstart++;


                //for printing last column in the matrix
                for (int i = rowstart; i <= rowend; i++)
                {
                    Console.WriteLine(matrix[i][columnend]);
                }
                //moving one column left side
                columnend--;

                //if rowstart is les than rowend
                if (rowstart < rowend)
                {                                              
                    for (int i = columnend; i >= columnstart; i--)
                    {
                        Console.WriteLine(matrix[rowend][i]);
                    }
                    rowend--;
                }

                //if columnstart is less than columnend
                if (columnstart < columnend)
                {

                    for (int i = rowend; i >= rowstart; i--)
                    {
                        Console.WriteLine(matrix[i][columnstart]); ;
                    }
                    columnstart++;
                }
            }

            
           

        }
    }
}
