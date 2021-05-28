using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProgram
{
    public class ReminderQuotient
    {
        int quotient = 0;
        int reminder = 0;
        public void QuotientReminderValue()
        {
            Console.WriteLine("Enter divisor");
            Console.WriteLine("enter divident");

            int divident = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = divident / divisor;
            int reminder = divident % divisor;

            Console.WriteLine("value of quotient is :" + quotient);
            Console.WriteLine("value of reminder is :" + reminder);


        }

    }
}
