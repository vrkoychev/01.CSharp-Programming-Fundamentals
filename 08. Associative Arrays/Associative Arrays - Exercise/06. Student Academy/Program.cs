using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int pairOfRows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>(); 

            for (int i = 0; i < pairOfRows; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(studentName))
                {
                    foreach (var kvp in students)
                    {
                        if (kvp.Key == studentName)
                        {
                            kvp.Value.Add(studentGrade);
                        }
                    }
                }
                else
                {
                    List<double> studentGrades = new List<double>();
                    studentGrades.Add(studentGrade);
                    students.Add(studentName, studentGrades);
                }
            }

            foreach (var kvp in students)
            {
                if (kvp.Value.Average() >= 4.50)
                    Console.WriteLine($"{kvp.Key} -> {(kvp.Value.Average()):F2}");
            }
        }
    }
}
