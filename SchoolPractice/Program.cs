using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            // let's create a student and test our methods
            Student joe = new Student("Joe", 1, 69, 4.20);
            Console.WriteLine(joe);
            // test the AddGrade method
            // What is Joe's GPA? 4.20
            // Joe's current number of credits is 69
            // current total quality score -> 4.20 * 69
            // Joe just took a new course, and we need calculate his new GPA
            // based on the credits and grade he got in the course
            // How many credits should course be worth and what grade did he get?
            // course credits hours -> 40
            // grade -> 1.2
            joe.AddGrade(40, 1.2);
            Console.WriteLine("Joe just took a new course worth 40 credits and got\na score of 1.2...");
            Console.WriteLine(joe);


            Student violet = new Student("Violet", 2, 15, 3.87);
            Console.WriteLine(violet);
            Console.WriteLine($"Does joe = violet? {joe.Equals(violet)}\n");
            Student todd = new Student("Todd", 2);
            Console.WriteLine(todd);
            // since todd and violet have the same, our Equals method will 
            // return true
            Console.WriteLine($"Does todd = violet? {todd.Equals(violet)}");
        }
    }
}
