using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProgram
{
   public class HarmonicNumber
    {
        int harmonicValue, n;
        double sum = 0.0;
        public void HarmonicNumberProgram()
        {
            Console.Write("\n\n");
            Console.Write("Calculate the harmonic series and their sum:\n");
            Console.Write("\n\n");

            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (harmonicValue = 1; harmonicValue <= n; harmonicValue++)
            {
                Console.Write("1/{0} + ", harmonicValue);
                sum += 1 / (float)harmonicValue;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", n, sum);
        }
        
    }
}
