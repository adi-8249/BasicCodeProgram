using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProgram
{
    public class OddEven
    {
        int temp = 0;
        public void OddEvenNumber()
        {

            Console.Write("Enter a Number : ");
            temp = int.Parse(Console.ReadLine());
            if (temp % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
