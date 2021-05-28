using System;

namespace BasicCodeProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1:flip coin percentage");
            Console.WriteLine("2:Leapyear program");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoinProgram flipcoin = new FlipCoinProgram();
                    flipcoin.FlipCoinPercentage();
                    break;
                case 2:
                    LeapYearProgram leapyear = new LeapYearProgram();
                    leapyear.LeapYear();
                    break;

            }
           
        }
    }
}
