using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();  

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                string firstName = data[0];
                string lastName = data[1];
                decimal grade = decimal.Parse(data[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }

            students.Sort((a,b) => a.Grade.CompareTo(b.Grade));
            students.Reverse();

            foreach (Student st in students)
            {
                Console.WriteLine($"{st.FirstName} {st.LastName}: {st.Grade}");
            }
        }
    }
}
