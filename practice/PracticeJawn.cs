using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class PracticeJawn
    {


        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public void WriteSomething()
        {
            Console.WriteLine("Something");
            Console.Read();
        }

        public void CalculatorAdd()
        {
            Console.WriteLine("Enter the first number: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second number: ");
            string input2 = Console.ReadLine();


            try
            {
                int num1 = int.Parse(input1);
                int num2 = int.Parse(input2);
            } catch (Exception)
            {
                Console.WriteLine("Format exception, please use a whole number next time");
            }


        }

    }
}
