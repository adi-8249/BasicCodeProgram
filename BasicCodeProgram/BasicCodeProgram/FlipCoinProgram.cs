using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProgram
{
    class FlipCoinProgram
    {
        public int heads = 0;
        public int tails = 0;

        public void FlipCoinPercentage()
        {
            Console.WriteLine("Enter how many times u want to flip");
            int flipnumber = Convert.ToInt32(Console.ReadLine());

            for (int coinflip = 0; coinflip <= flipnumber; coinflip++)
            {
                Random random = new Random();
                double flipcoin = random.NextDouble();
                if (flipcoin < 0.5)
                    tails++;
                else
                    heads++;
            }
            double percentagetails = (tails * 100) / flipnumber;
            double percentageheads = (heads * 100) / flipnumber;
            Console.WriteLine("percentage of heads" + percentageheads);
            Console.WriteLine("percentage of tails" + percentagetails);
        }

    }
}
