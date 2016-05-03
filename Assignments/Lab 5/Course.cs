﻿
namespace Lab_5
{
    class Course
    {
        private string Name;
        private string CRN;
        private Student[] ArrayOfStudents;

        public static int NbrStudents;

        public Course(string name, string crn)
        {
            this.Name = name;
            this.CRN = crn;
        } // end constructor Course 

        public void GetCourseStudents(int NbrStudents)
        {
            Course.NbrStudents = NbrStudents;
            ArrayOfStudents = new Student[Course.NbrStudents];

            for (int i = 0; i < Course.NbrStudents; i++)
            {
                this.ArrayOfStudents[i] = new Student();
                this.ArrayOfStudents[i].GetStudentData();
            }
        } // end method GetCourseStudents

        public bool PrintInfo()
        {
            System.Console.WriteLine("Course Name: " + this.Name);
            System.Console.WriteLine("CRN        : " + this.CRN);

            for (int i = 0; i < Course.NbrStudents; i++)
            {
                this.ArrayOfStudents[i].PrintStudent();
            }

            System.Console.WriteLine();
            System.Console.WriteLine("If the information is correct, press'Y' to continue.");
            System.Console.WriteLine("Pressing 'N' will allow you to start over.");
            string prompt = "Enter (Y/N)";
            return Gather.GetBool(prompt);
       }
    } // end class Course
} 
