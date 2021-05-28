using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProgram
{
    public class PowerOfTwo
    {
        public int PowerOfTwoResult(int value)
        {
           
                int temp = 1;
                for (int i = 1; i <= value; i++)
                {
                    temp = temp * 2;
                }
                return temp;
        }
    }

}
