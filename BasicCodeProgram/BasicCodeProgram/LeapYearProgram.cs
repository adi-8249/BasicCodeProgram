using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProgram
{
    class LeapYearProgram
    {
        public void LeapYear()
        {
            Console.WriteLine("Enter a year here :");
            int year = int.Parse(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", year);

            }
            else
            { 
                Console.WriteLine("{0} is not a Leap Year.", year);
              
            }
        }
    }
}
