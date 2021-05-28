using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProgram
{
    public class LargestAmongNumbers
    {
       public void LargestNumber(int randomnum1, int randomnum2,int randomnum3)
        {
            int max = randomnum1;

            if (randomnum1 >= randomnum2 && randomnum1 >= randomnum3)
                max = randomnum1;
            if (randomnum2 >= randomnum1 && randomnum2 >= randomnum3)
                max = randomnum2;
            if (randomnum3 >= randomnum1 && randomnum3 >= randomnum2)
                max = randomnum3;

            Console.WriteLine("largest number among {0}, {1} and {2} is: {3}",
                               randomnum1, randomnum2, randomnum3, max);
        }
    }
}
