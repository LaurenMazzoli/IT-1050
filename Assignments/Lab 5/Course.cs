
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
        } // end Course Constructor

        public void GetCourseStudents(int NbrStudents)
        {
            Course.NbrStudents = NbrStudents;
            ArrayOfStudents = new Student[Course.NbrStudents];

            for (int i = 0; i < Course.NbrStudents; i++)
            {
                this.ArrayOfStudents[i] = new Student();
                this.ArrayOfStudents[i].GetStudentData();
            }
        } // end GetCourseStudents Method

        public bool PrintInfo()
        {
            System.Console.WriteLine("Course Name: " + this.Name);
            System.Console.WriteLine("CRN        : " + this.CRN);

            for (int i = 0; i < Course.NbrStudents; i++)
            {
                this.ArrayOfStudents[i].PrintStudent();
            }

            System.Console.WriteLine();
            System.Console.Write("Is all information correct: (Y/N): ");

            string input = System.Console.ReadLine();
            bool isOK = false;

            if (input.ToLower().StartsWith("y"))
            { 
                    isOK = true;
            }
            return isOK;
       }
    } // end class Course
} 
