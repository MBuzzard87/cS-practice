using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.Read();

            //Data Types


            ///////////////String type/////////////////////////
            
            //String = allows multiple letters
            string name = "Mike";
            
            
            
            ////////////////Primitive Types/////////////////

            //Short = whole numbers from -32767 to 32767
            short a = 30000;

            //Integer = whole numbers from -2,147,483,648 to 2,147,483,647
            int num = 1;

            //Long = whole numbers from -9,223,327,036,854,775,808 to 9,223,327,036,854,775,807
            long l = 9_000_000_000_000_000_000;

            //Signed Byte = whole numbers from -128 to 127
            sbyte x = 120;

            //Float = allows decimals and a range from 1.5 x 10^-45 to 3.4 x 10^38 
            // 7 digit precision
            float f = 99.99f;

            //Double = allows decimals and an even higher range than the float
            // 15 digit precision
            double d = 1.5;

            //Decimal = allows decimals and an even higher range than the double
            // 28 digit precision
            decimal y = 1.2m;

            //Boolean = only allows two states: true / false
            bool b = false;

            //Char = allows a single character literal or unicode
            char c = 'A';


            //////Test write/read ////////


            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();
        }
    }
}
