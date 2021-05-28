using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodeProgram
{
    public class VowelAndConsonant
    {
        public void VowelConsonant(char alphabet)
        {
            char check = char.ToLower(alphabet);
            if (check == 'a' || check == 'e' || check == 'i' || check == 'o' || check == 'u') 
            {  
                Console.WriteLine(alphabet + " is Vowel.");
            }
            else
            {
                Console.WriteLine(alphabet + " is Consonant.");
            }
        }

    }
}
