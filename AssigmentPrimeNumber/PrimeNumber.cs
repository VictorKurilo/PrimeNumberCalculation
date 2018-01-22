using System;

namespace AssigmentPrimeNumber
{
    public class PrimeNumber
    {        
        /// <summary>
        /// Prints prime number of the result multiplication three prime numbers
        /// </summary>
        
        public static void GetPrimeNumber(int number)
        {
            // stores real value of number 
            int tempNumber = number;

            // stores prime numbers 
            string numbersResult = null;

            // checks number for prime number, prints 'no' if doesn't find any
            if (number == 1 || number == 2 || number % 2 == 0)
            {
                Console.WriteLine("No");
                return;
            }
            else
            {
                numbersResult += "Yes, ";

                // since number must be odd, we can skip one element
                // note: i = i + 2
                for (int i = 3; i < Math.Sqrt(number); i += 2)
                {
                    // while i divides number, we store it in numberResult and divide by number
                    while (number % i == 0)
                    {
                        numbersResult = numbersResult + i.ToString() + " * ";
                        number /= i;
                    }
                }

                // condition to handle when prime number greater than 2, we store it in numberResult
                if (number > 2)
                {
                    numbersResult = numbersResult + number.ToString();

                }

                // Prints sum prime number of the result of multiplication of three prime numbers
                // example 3 * 5 * 7 = 105
                Console.WriteLine(numbersResult.ToString() + " = " + "{0}", tempNumber);
            }
        }
    }
}
