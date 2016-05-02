namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {

            bool courseOK = false;
            while (!courseOK)
            {
                System.Console.Write("Course Name: ");
                string name = System.Console.ReadLine();

                System.Console.Write("Course Number: ");
                string crn = System.Console.ReadLine();

                Course course = new Course(name, crn);

                System.Console.Write("Number of Students in Course " + crn + ": ");
                int nbrStudents = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine();
                course.GetCourseStudents(nbrStudents);

                System.Console.WriteLine("=== Verifying Information ===");

                courseOK = course.PrintInfo();
            }
            System.Console.Write("Press any key to Exit the program ...");
            System.Console.ReadLine();
        } // end main
    } // end Program
} // end Lab 5
