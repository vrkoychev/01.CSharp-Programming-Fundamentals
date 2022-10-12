using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double cost = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfTheWeek == "Friday")
                    cost = countOfPeople * 8.45;
                else if (dayOfTheWeek == "Saturday")
                    cost = countOfPeople * 9.80;
                else if (dayOfTheWeek == "Sunday")
                    cost = countOfPeople * 10.46;

                if (countOfPeople >= 30)
                    cost = cost - cost * 0.15;
            }
            else if (typeOfGroup == "Business")
            {
                if (countOfPeople >= 100)
                    countOfPeople -= 10;

                if (dayOfTheWeek == "Friday")
                    cost = countOfPeople * 10.90;
                else if (dayOfTheWeek == "Saturday")
                    cost = countOfPeople * 15.60;
                else if (dayOfTheWeek == "Sunday")
                    cost = countOfPeople * 16;
            }
            else if (typeOfGroup == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                    cost = countOfPeople * 15;
                else if (dayOfTheWeek == "Saturday")
                    cost = countOfPeople * 20;
                else if (dayOfTheWeek == "Sunday")
                    cost = countOfPeople * 22.50;

                if (countOfPeople >= 10 && countOfPeople <= 20)
                    cost = cost - cost * 0.05;
            }

            Console.WriteLine($"Total price: {cost:F2}");
        }
    }
}
