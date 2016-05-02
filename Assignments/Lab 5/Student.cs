namespace Lab_5
{
    class Student
    {
        string Name;
        string Number;

        public void GetStudentData()
        {

            System.Console.Write("Student Name             : ");
            this.Name = System.Console.ReadLine();

            System.Console.Write("Student Number (S9999999): ");
            this.Number = System.Console.ReadLine();

            System.Console.WriteLine();

        }

        public void PrintStudent()
        {
            System.Console.WriteLine("Student    :" + this.Number + " " + this.Name); 
        }        
    }
}
