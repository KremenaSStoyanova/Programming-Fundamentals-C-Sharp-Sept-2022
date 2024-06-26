﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmdArgs = input.Split();

                string name = cmdArgs[0];
                string id = cmdArgs[1];
                int age = int.Parse(cmdArgs[2]);

                Student student = new Student(name, id, age);
                bool isIDMissing = true;

                for (int i = 0; i < students.Count; i++)
                {
                    Student currentStudent = students[i];
                    if (currentStudent.ID == id)
                    {
                        isIDMissing = false;
                        students[i].Name = name;
                        students[i].Age = age;
                        break;
                    }
                }
                if (isIDMissing)
                {
                    students.Add(student);
                }

                input = Console.ReadLine();
            }

            foreach (var currentStudent in students.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{currentStudent.Name} with ID: {currentStudent.ID} is {currentStudent.Age} years old.");
            }
        }
    }

    public class Student
    {
        public Student(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}
