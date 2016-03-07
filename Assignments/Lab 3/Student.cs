namespace Lab_3
{
    public class Student
    {
        // capitalize all member variable names in the class

        private string Name;
        private Instructor Teacher;
        private int Grade;

        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Grade = 0;
        }
        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }
        public void PrintStudentInfo()
        {
            // private Instructor teacher;

            System.Console.WriteLine("==========================");
            System.Console.WriteLine("Student: " + this.Name);
            this.Teacher.PrintTeacherInfo();
            System.Console.WriteLine("Grade: " + this.Grade);
        }
    }
}