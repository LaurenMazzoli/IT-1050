namespace Lab_3
{
    // +============================================================+
    // +   Course: IT-1050                                          +
    // +   Date: 3/09/16                                            +
    // +   Assigment: Lab 3                                         +
    // +   Name: Lauren Mazzoli                                     +
    // +============================================================+

    class Program
    {
        static void Main(string[] args)
        {
            var john = new Instructor("John", "English");
            var mike = new Instructor("Mike", "Math");

            var jane = new Student("Jane", john);
            var joe = new Student("Joe", john);
            var melissa = new Student("Melissa", mike);
            var matt = new Student("Matt", mike);

            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);

            mike.SetStudentGrade(melissa, 90);
            mike.SetStudentGrade(matt, 92);

            Show.Divider();
            Show.Header();

            jane.PrintStudentInfo();
            joe.PrintStudentInfo();
            melissa.PrintStudentInfo();
            matt.PrintStudentInfo();

            Show.Divider();
            Show.ProgEnd();
        }
    }
}
