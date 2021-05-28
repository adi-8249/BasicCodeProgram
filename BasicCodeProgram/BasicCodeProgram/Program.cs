using System;

namespace BasicCodeProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1:flip coin percentage");
            Console.WriteLine("2:Leapyear program");
            Console.WriteLine("3:poweroftwo program");
            Console.WriteLine("4:Harmonic number");
            Console.WriteLine("5:Primefactor");
            Console.WriteLine("6:Reminder and quotient");
            Console.WriteLine("7:Swaping two number");
            Console.WriteLine("8:OddEven number program");
            Console.WriteLine("9:Vowel and consonant");
            Console.WriteLine("10:largest number among three number");

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

                case 3:
                    PowerOfTwo poweroftwo = new PowerOfTwo();
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    Console.WriteLine("Enter the number to check its 2's power=");
                    int input = Convert.ToInt32(Console.ReadLine());
                    int result = powerOfTwo.PowerOfTwoResult(input);
                    Console.WriteLine("result is=" + result);
                    break;

                case 4:
                    HarmonicNumber harmonicnumber = new HarmonicNumber();
                    harmonicnumber.HarmonicNumberProgram();
                    break;

                case 5:
                    FactorProgram factor = new FactorProgram();
                    factor.PrimeFactor();
                    break;

                case 6 :
                    ReminderQuotient reminderquotient = new ReminderQuotient();
                    reminderquotient.QuotientReminderValue();
                    break;

                case 7 :
                    SwapingNumber swapnumber = new SwapingNumber();
                    swapnumber.SwapTwoNumber();
                    break;

                case 8:
                    OddEven oddeven = new OddEven();
                    oddeven.OddEvenNumber();
                    break;

                case 9:
                    VowelAndConsonant vowelandconsonant = new VowelAndConsonant();
                    vowelandconsonant.VowelConsonant('c');
                    break;

                case 10:
                    LargestAmongNumbers largestnumber = new LargestAmongNumbers();
                    Random random = new Random();
                    int randomnum1 = random.Next(0, 100);
                    int randomnum2 = random.Next(0, 100);
                    int randomnum3 = random.Next(0, 100);
                    largestnumber.LargestNumber(randomnum1, randomnum2, randomnum3);
                    break;

            }
           
        }
    }
}
