using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayLeetCodeProblems
{
    class RomantoInteger
    {
       public int Roman(char r)
       {
            if(r == 'I')
            {
                return 1;

            }
            if (r == 'V')
            {
                return 5;

            }
            if (r == 'X')
            {
                return 10;

            }
            if (r == 'L')
            {
                return 50;

            }
            if (r == 'C')
            {
                return 100;

            }
            if (r == 'D')
            {
                return 500;

            }
            if (r == 'M')
            {
                return 1000;

            }
            return -1;
        }

        public int RomantoDec(string str)
        {
            int answer = 0;
            int previous = 0;
            int n = str.Length - 1;

            for(int i=n;i>=0;i--)
            {
                if(str[i]>=previous)
                {
                    //if it is greater that previous ading the current to answer
                    answer = answer + str[i];
                }
                else
                {
                    ////if it is less that previous ading the current to answer
                    answer = answer - str[i];
                }
            }
            return answer;
        }
    }
}
