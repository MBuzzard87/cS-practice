using System;

namespace practice
{
    class Program
    {


        //Constants - immutable
        const double PI = 3.1459265359;
        const int weeks = 52, months = 12;
        

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.Read();

            //Console colors

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();


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

/*            Console.WriteLine("Enter a string to print value");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.WriteLine("Enter a character to find the int ASCII value");
            int asciiValue = Console.Read();
            Console.WriteLine($"ASCII value is {asciiValue} and you previously entered the string: {readInput}");
            //or
            Console.WriteLine("ASCII value is {0} and you previously entered the string: {1}", asciiValue, readInput);

            // add an @ symbol before the string for it to take the string literally
            Console.WriteLine(@"Verbatim strings
Example for verbatim string: C:\User\Admin\Dogpics\shia.png

Allows you to pass escape characters, ex: \n 
            ASCII value is {0} and you, 
                
                
            previously entered the string: {1}", asciiValue, readInput);

            string strNum = "20";
            int numStr = Int32.Parse(strNum);
            Console.WriteLine(numStr);

*/
            Console.Write("Enter a string here: ");
            string input = Console.ReadLine();

            Console.Write("Enter a character to search for: ");
            char numSearch = Console.ReadLine()[0];
            int searchIndex = input.IndexOf(numSearch);

            Console.WriteLine("Index of character {0} in string is {1}", numSearch, searchIndex);
            PracticeJawn pj = new PracticeJawn();
            Console.WriteLine(pj.Add(3, 4));
            pj.WriteSomething();

            pj.CalculatorAdd();


            Console.ReadKey();
        }
    }
}
