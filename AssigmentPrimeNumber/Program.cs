using System;

namespace AssigmentPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // entry to program
            PrimeNumber.GetPrimeNumber(UserInput.Input());
                
            // dellay
            Console.WriteLine("press any key to exit..");
            Console.ReadLine();
        }
    }
}
