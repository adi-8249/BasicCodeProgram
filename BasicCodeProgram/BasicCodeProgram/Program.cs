using System;

namespace BasicCodeProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1:flip coin percentage");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoinProgram flipcoin = new FlipCoinProgram();
                    flipcoin.FlipCoinPercentage();
                    break;

            }
           
        }
    }
}
