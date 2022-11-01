using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();

            string str1 = str[0];
            string str2 = str[1];
            int totalSum = 0;

            totalSum = GetCharCodesmultiplied(str1, str2, totalSum);

            Console.WriteLine(totalSum);
        }

        private static int GetCharCodesmultiplied(string str1, string str2, int totalSum)
        {
            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    int num1 = (int)str1[i];
                    int num2 = (int)str2[i];
                    totalSum += num1 * num2;
                }

                for (int j = str2.Length; j < str1.Length; j++)
                {
                    int num = str1[j];
                    totalSum += num;
                }
            }
            else if (str1.Length < str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    int num1 = (int)str1[i];
                    int num2 = (int)str2[i];
                    totalSum += num1 * num2;
                }

                for (int j = str1.Length; j < str2.Length; j++)
                {
                    int num = str2[j];
                    totalSum += num;
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    int num1 = (int)str1[i];
                    int num2 = (int)str2[i];
                    totalSum += num1 * num2;
                }
            }

            return totalSum;
        }
    }
}
