namespace Lab_5
{
    class Student
    {
        string Name;
        string Number;

        public Student()
        {
            Name = "";
            Number = "";
        }


        public void GetStudentData()
        {

            while (this.Name == "")
            {
                this.Name = Gather.GetString("Student Name");
            }
            while (this.Number == "")
            {
                this.Number = Gather.GetString("Student Number (S99999999)");
            }
            System.Console.WriteLine();
        }

        public void PrintStudent()
        {
            System.Console.WriteLine("Student: " + this.Number + " " + this.Name); 
        }        
    }
}
