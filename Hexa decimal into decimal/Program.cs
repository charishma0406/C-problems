using System;

namespace Hexa_decimal_into_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexnum = "4B0";
            //converting hexadecimal into deciamla we use this parse method and sys gob .hex num
            int num = Int32.Parse(hexnum , System.Globalization.NumberStyles.HexNumber);
            //output will be 1200
            Console.WriteLine(num);
        }
    }
}
