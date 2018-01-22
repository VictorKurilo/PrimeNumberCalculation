using System;
using System.Text.RegularExpressions;

namespace AssigmentPrimeNumber
{
    class UserInput
    {
        /// <summary>
        /// Validates user string input
        /// </summary>
        /// <returns>integer</returns>
        public static int Input()
        {
            // ask user to input integer than save it in userInput
            Console.WriteLine("Enter positive integer!");
            string userInput = Console.ReadLine();

            // only accept input of integers
            Regex validate = new Regex(@"^[0-9]");

            // checks for string null or empty and if our string matches regex validation
            if (string.IsNullOrEmpty(userInput) || validate.IsMatch(userInput))
            {
                // converts string to integer
                return Convert.ToInt32(userInput);
            }
            else
            {
                // return 0 if invalid input
                return 0;
            }
        }
    }
}
