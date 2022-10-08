using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();

            if (type == "int")
            {
                int firstInt = int.Parse(firstValue);
                int secondInt = int.Parse(firstValue);
                int result = GetMax(firstInt, secondInt);
                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(firstValue);
                char secondChar = char.Parse(secondValue);
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                string result = GetMax(firstValue, secondValue);
                Console.WriteLine(result);
            }
        }

        private static string GetMax(string firstValue, string secondValue)
        {
            int result = firstValue.CompareTo(secondValue);

            if (result > 0)
                return firstValue;

            return secondValue;
            
        }

        private static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
                return firstChar;

            return secondChar;
        }

        private static int GetMax(int firstInt, int secondInt)
        {
            if (firstInt > secondInt)
                return firstInt;

            return secondInt;
        }
    }
}
