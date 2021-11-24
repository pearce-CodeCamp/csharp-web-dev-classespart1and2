using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        // We are recalculating the GPA of a student after they take a new course
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            // Calculate the current total quality score for the student
            // total about of points for all courses taken
            // A is 4, B is 3, C is 2, D is 1, F is 0 
            // if gpa is 4.2 and credit hours is 69, then this will 289.8
            double currentTotalQS = Gpa * NumberOfCredits;
            // Method takes in a number of credits and the student's grade for a course
            // calculate the student's quality score for the course
            // courseCredits: 40, grade: 1.2, so newCourseQS 48
            double newCourseQS = grade * courseCredits;
            // Add that score for the individual course to the total quality score
            // of the student
            // newTotalQS 337.8
            double newTotalQS = currentTotalQS + newCourseQS;
            // update the student's NumberOfCredits using setter
            // NumberOfCredits currently is 69, courseCredits is 40,
            // so we reassign NumberOfCredits to 69 + 40, or 109
            NumberOfCredits += courseCredits;
            // calculate new GPA based on the new total quality score
            // GPA is the average of total points scored based on number of credits
            // newTotalQS is 337.8, new NumberOfCredits is 109,
            // so GPA should calculates to ~3.1
            Gpa = newTotalQS / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
        // now we can just call someStudent.GetGradeLevel() and we'll get a string
        // back telling us what grade level someStudent
        public string GetGradeLevel(/*int credits*/)
        {
            // Determine the grade level of the student based on NumberOfCredits
            // if 0-29, freshman
            // if 30-59, sophomore
            // if 60-89, junior
            // if 90+, senior
            // we have access to the numberOfCredits of a given student via the getter of
            // the numberOfCredits property
            // If we have we use the parameter, then when we go to call this GetGradeLevel
            // method on a student object, we'll have to pass the numberOfCredits in
            // I am not going to use the parameter since we already have access to the 
            // property via its getter
            // NumberOfCredits is like saying this.numberOfCredits in JS
            if (NumberOfCredits <= 29)
            {
                // grade level is freshman
                return "freshman";
            } 
            else if(NumberOfCredits <= 59)
            {
                return "sophomore";
            } 
            else if(NumberOfCredits <= 89)
            {
                return "junior";
            }
            else if(NumberOfCredits > 89)
            {
                return "senior";
            }
            return "grade level tbd";
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"ID: {StudentId}\n" +
                $"Grade Level: {GetGradeLevel()}\n" +
                $"Credit Hours: {NumberOfCredits}\n" +
                $"GPA: {Gpa}\n";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
        // if the id is the same for two student objects, they are the same student
        public override bool Equals(object obj)
        {
            // based on code from ~line 30 in Program.cs,
            // we have invoked the Equals method on the joe object,
            // and passed in the violet object
            // now in this context, obj is violet
            // is this context though, what is Violet's data type?
            // SPECIFICALLY IN THIS SCOPE/CONTEXT, Violet is of type OBJECT!!!
            // This is a primer on polymorphism
            // Violet isn't only just an object, Violet is still a Student
            // But until cast Violet as a Student, our code will still only recognize
            // Violet as just an object
            // But what's weird is when we call the GetType method, it indicates that
            // obj is a Student
            // So obj kind of has multiple types as the same time??????
            Console.WriteLine(obj.GetType());
            if (obj.GetType() != GetType())
            {
                return false;
            }

            // we can't actually treat obj as a Student until we cast it as a Student
            // By treat I mean to say we can't access any properties or
            // methods of obj that relate to the Student class
            Student studentToBeCompared = obj as Student;
            return studentToBeCompared.StudentId == StudentId;
        }
    }
}
