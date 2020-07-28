using System;

namespace Celsius_to_F_and_celsius_to_kelvin
{
    class Program
    {
        static void Main(string[] args)
        {

            //celsius is that the user entered
            //celsius to kelvin formula is celsius + 273
            //celsius to fahrenhient is celsius*18/10+32


            int x;

            int x1 = int.Parse(Console.ReadLine());

          


            Console.WriteLine("celsius to kelvin = " + (x1+ 273));
            Console.WriteLine("celsius to fareheint = " + ((x1*18)/10+32));







        }
    }
}
