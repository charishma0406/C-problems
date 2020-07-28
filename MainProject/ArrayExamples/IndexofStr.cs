using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    class IndexofStr
    {
        public int Index(string s1, string s2)
        {
            /*if(s1.Length<s2.Length)
            {
                Console.WriteLine("null");
            }
            int a = s1.IndexOf(s2);
            Console.WriteLine(a);*/

            if(s1.Length<s2.Length)
            {
                return -1;
            }
            int index = 0;
            for (int i=0;i<s1.Length;i++)
            {
                index = i;
                
                for(int j = 0; j <s2.Length;j++)
                {
                    if(s1[i] == s2[j])
                    {
                        i++;
                        j++;
                            
                    }
                    if(j== s2.Length)
                    {
                        return index;
                    }
                    i = index;

                }
               
            }
            return -1;

        }
    }
}
