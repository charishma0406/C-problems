using System;
using System.IO;

namespace Length_of_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\v-chdara\Desktop\file.txt";
            FileInfo fi = new FileInfo(path);
            Console.WriteLine(fi.Length.ToString());
        }
    }
}
