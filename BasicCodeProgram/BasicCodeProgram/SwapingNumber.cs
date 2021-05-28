using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProgram
{
    class SwapingNumber
    {
        public void SwapTwoNumber()
        {   

            Console.WriteLine("Enter first Number");
            Console.WriteLine("Enter second number");

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Values before swap...");
            Console.WriteLine(number1.ToString());
            Console.WriteLine(number2.ToString());

            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;

            Console.WriteLine("Values after swap...");
            Console.WriteLine(number1.ToString());
            Console.WriteLine(number2.ToString());
            Console.ReadLine();

        }
    }
}
