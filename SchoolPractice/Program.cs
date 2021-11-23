using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student john = new Student("John", 1, 1, 4.0);
            Console.WriteLine($"The new student's name is {john.Name}");
            // this code below works because Name is public in the Student class
            // regardless of whether or not Student has a constructor
            /*newStudent.Name = "John";
            Console.WriteLine(newStudent.Name);
            newStudent.Name = "Claire";
            Console.WriteLine(newStudent.Name);*/
            Student pri = new Student("Pri", 2, 1, 4.0);
            Student sandhya = new Student("Sandhya", 3, 1, 4.0);
            List<Student> roster = new List<Student>();
            roster.Add(john);
            roster.Add(pri);
            roster.Add(sandhya);

            Teacher gerard = new Teacher("Gerard", "Darris", "Web Dev", 2);

            Course codeCamp = new Course("STLCC CodeCamp 2021", gerard, roster);
            Console.WriteLine($"The name of the course is: {codeCamp.Title}");
            Console.WriteLine($"Instructor: {codeCamp.Instructor.FirstName} {codeCamp.Instructor.LastName}");
            Console.WriteLine("Students:");
            foreach (Student student in codeCamp.StudentRoster)
            {
                Console.WriteLine($"{student.Name}");
            }
        }
    }
}
