using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    public static class Helper
    {
        public static uint ParseUserInput(string messageToDisplay)
        {
            bool isValid;
            uint parsedNumber;
            do
            {
                Console.WriteLine(messageToDisplay);
                string userInput = Console.ReadLine();
                isValid = uint.TryParse(userInput, out parsedNumber);
                if (!isValid)
                {
                    Console.WriteLine("Input has to be a natural numeber.");
                }
            }
            while (!isValid);

            return parsedNumber;
        }
        public static bool ParseBoolInput(string massageToDisplay)
        {
            bool isValid;
            bool parsedNumber;
            do
            {
                Console.WriteLine(massageToDisplay);
                string userInput = Console.ReadLine();
                isValid = bool.TryParse(userInput, out parsedNumber);
                if (!isValid)
                {
                    Console.WriteLine("input has to be true or false.");
                }
            }
            while (!isValid);

            return parsedNumber;
        }

    }
}
