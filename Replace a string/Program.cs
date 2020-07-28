using System;

namespace Replace_a_string
{
    class Program
    {
        public static string firstlast(string user)
        {

            string result;




           if(user.Length>1)
            {
                result = user.Substring(user.Length - 1) + user.Substring(1, user.Length - 2) + user.Substring(0, 1);
            }
            else
            {
               result = user;
            }

            return result;

           /* return user.Length > 1
                ? user.Substring(user.Length - 1) + user.Substring(1, user.Length - 2) + user.Substring(0, 1) : user;*/





        }
        static void Main(string[] args)
        {
            // string ch = "cherry";
            //string substr=  ch.Substring(0,6);


            //Console.WriteLine(substr);
            Console.WriteLine(firstlast("cherry"));
            Console.WriteLine(firstlast("chetan"));


        }
    }
}
