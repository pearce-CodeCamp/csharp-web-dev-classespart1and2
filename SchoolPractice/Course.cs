using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    internal class Course
    {
        public string Title { get; set; }
        // instead of just making the instructor property a string,
        // let's refactor to have it be an instance of the Teacher class
        // public string Instructor { get; set; }
        public Teacher Instructor { get; set; }
        // this property StudentRoster can only contain instances of the Student
        // class!!!!!!!
        public List<Student> StudentRoster { get; set; }

        public Course(string title, Teacher instructor, List<Student> roster)
        {
            Title = title;
            Instructor = instructor;
            StudentRoster = roster;
        }
    }
}
