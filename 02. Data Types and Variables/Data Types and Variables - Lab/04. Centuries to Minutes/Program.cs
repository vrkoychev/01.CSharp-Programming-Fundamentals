using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            double days = years * 365.2422;
            int trueDays = (int)days;
            int hours = (int)days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {trueDays} days = {hours} hours = {minutes} minutes");
        }
    }
}
