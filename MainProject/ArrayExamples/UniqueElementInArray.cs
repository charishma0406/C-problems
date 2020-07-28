using System;
using System.Collections.Generic;
using System.Text;

namespace MainProject.ArrayExamples
{
    public class UniqueElementInArray
    {
        public void Unique()
        {
            //initialising an array
            int[] array = new int[7] { 2,4,6,4,2,3,3};

            //create dictionary to store the array elements in that.
            Dictionary<int, int> dict = new Dictionary<int, int>();

            //iterating the array to store in the dictionary
           for(int i =0;i<array.Length;i++)
            {
                //if my dictionary contains that key
                if(dict.ContainsKey(array[i]))
                {
                    //my value is array[i]
                    int value = array[i];
                    //then the element of arr[i] is value++. we need to increment the value
                    dict[array[i]] = value++;
                    
                }

                else
                {
                    //else just add the array element in to the dictionary
                    dict.Add(array[i], 1);
                }
            }

           //iterate the dict to chechk the unique value
           foreach(KeyValuePair<int,int> temp in dict)
            {
                if(temp.Value == 1)
                {
                    Console.WriteLine(temp.Key);
                }
            }



        }
    }
}
