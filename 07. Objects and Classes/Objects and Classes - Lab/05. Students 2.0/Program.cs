using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Student> studentInfo = new List<Student>();

            while (input != "end")
            {
                string[] data = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string homeTown = data[3];

                bool doesStudentExist = DoesStudentExist(studentInfo, firstName, lastName);

                if (doesStudentExist)
                {
                    Student existingStudent = GetExistingStudent(studentInfo, firstName, lastName);

                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;
                }
                else
                {
                    Student newStudent = new Student(firstName, lastName, age, homeTown);

                    studentInfo.Add(newStudent);
                }

                input = Console.ReadLine();
            }

            string cityName = Console.ReadLine();

            foreach (Student student in studentInfo)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        private static Student GetExistingStudent(List<Student> studentInfo, string firstName, string lastName)
        {
            foreach (Student student in studentInfo)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return student;
                }
            }

            return null;
        }

        private static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
