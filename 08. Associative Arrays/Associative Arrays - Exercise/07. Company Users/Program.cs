using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> companys = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] data = input.Split(" -> ");

                string companyName = data[0];
                string employeeId = data[1];

                if (companys.ContainsKey(companyName))
                {
                    foreach (var kvp in companys)
                    {
                        if (kvp.Key == companyName)
                        {
                            if (kvp.Value.Contains(employeeId))
                            {
                                break;
                            }
                            else
                            {
                                kvp.Value.Add(employeeId);
                            }
                        }
                    }
                }
                else
                {
                    List<string> employeeIds = new List<string>();
                    employeeIds.Add(employeeId);
                    companys.Add(companyName, employeeIds);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in companys)
            {
                Console.WriteLine(kvp.Key);
                foreach (string id in kvp.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
