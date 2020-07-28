using System;

namespace integer20out_of100_or_200
{
    class Program
    {
        static void Main(string[] args)
        {

            int x1 = int.Parse(Console.ReadLine());
       
        }
            public static bool result(int n)
            {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                
                return true;
                return false;

                
            }
           
        }
    }

