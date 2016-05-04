namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            bool courseOK=false;
            Course newCourse;

            while (!courseOK)
            {
                newCourse = GetData();
                System.Console.WriteLine("===== Verifying Course Information =====");
                courseOK = newCourse.PrintInfo();
            }
            EndProg();
 
        } // end main

        static Course GetData()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Please enter information for your course.");
            System.Console.WriteLine();
            string name = Gather.GetString("Course Name        ");
            string crn =  Gather.GetString("CRN                ");
            
            Course course = new Course(name, crn);
            
            string prompt = "Number of Students ";
            int nbrStudents = 0;
            while (nbrStudents <= 0)
            {
                nbrStudents = Gather.GetInt(prompt);
            }

            System.Console.WriteLine();
            course.GetCourseStudents(nbrStudents);
            return course;
        } // end GetData method

        static void EndProg()
        {
            System.Console.WriteLine("Press any key to end Program...");
            System.Console.ReadLine();
        }
    } // end Program
} // end Lab 5
