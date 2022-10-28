using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int ammount = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += ammount;
                }
                else
                {
                    resources.Add(resource, ammount);
                }

                resource = Console.ReadLine();
            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
