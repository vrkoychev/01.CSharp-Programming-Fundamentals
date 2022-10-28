using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] data = input.Split(" : ");

                string courseName = data[0];
                string studentName = data[1];

                if (courses.ContainsKey(courseName))
                {
                    foreach (var kvp in courses)
                    {
                        if (kvp.Key == courseName)
                        {
                            kvp.Value.Add(studentName);
                        }
                    }
                }
                else
                {
                    List<string> studentNames = new List<string>();
                    studentNames.Add(studentName);
                    courses.Add(courseName, studentNames);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in courses)
            {
                int registeredStudents = 0;
                foreach (string student in kvp.Value)
                {
                    registeredStudents++;
                }
                Console.WriteLine($"{kvp.Key}: {registeredStudents}");
                foreach (string student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
