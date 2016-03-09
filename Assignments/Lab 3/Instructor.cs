namespace Lab_3
{
    public class Instructor
    {
        private string Name;
        private string CourseName;

    
        public Instructor(string name, string course)
        {
            this.Name = name;
            this.CourseName = course;
        }
        public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        } 
    
        public void PrintTeacherInfo()
        {
            Show.Name("Instructor", this.Name);
            Show.Name("Course", this.CourseName);
        }
    }
}
