using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PassWordIsValid(text);

        }

        private static void PassWordIsValid(string text)
        {
            int charCount = 0;
            bool onlyLettersAndDigits = true;
            int digitsCount = 0;

            foreach (var ch in text)
            {
                int currCh = (int)ch;

                charCount++;

                if (currCh < 48 || currCh > 57 && currCh < 65 || currCh > 90 && currCh < 97 || currCh > 122)
                    onlyLettersAndDigits = false;

                if (currCh >= 48 && currCh <= 57)
                    digitsCount++;
            }

            int mistakes = 0;

            if (charCount < 6 || charCount > 10)
            {
                mistakes++;
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!onlyLettersAndDigits)
            {
                mistakes++;
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (digitsCount < 2)
            {
                mistakes++;
                Console.WriteLine("Password must have at least 2 digits");
            }
            
            if (mistakes == 0)
                Console.WriteLine("Password is valid");
        }
    }
}
