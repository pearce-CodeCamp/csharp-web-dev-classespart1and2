using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolPractice
{
    internal class Teacher
    {
        // FirstName, LastName, Subject, and YearsTeaching.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

        public Teacher(string firstName, string lastName, string subject, int yearsTeaching)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
            YearsTeaching = yearsTeaching;
        }
    }
}
