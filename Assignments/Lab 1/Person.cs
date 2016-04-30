namespace Lab_1
{

    public class Person
    { // member variables of Person
        public string FirstName;
        public string MiddleInitial;
        public string LastName;
        public int Age;
        public bool IsCitizen;
        public double TotalHeightCM;

        public void GetDataFromUser()
        { // ** begin GetDataFromUser method **

            // ** get name from user **
            System.Console.Write("First Name: ");
            this.FirstName = System.Console.ReadLine();

            System.Console.Write("Middle Initial: ");
            this.MiddleInitial = System.Console.ReadLine();

            System.Console.Write("Last Name: ");
            this.LastName = System.Console.ReadLine();

            // ** get height from user **
            System.Console.Write("Height (feet only): ");
            int heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Height (inches only): ");
            double heightInches = double.Parse(System.Console.ReadLine());

            // ** calculate height in Inches and convert to Centimeters **
            double totalHeightIN = heightFeet * 12 + heightInches;
            this.TotalHeightCM = totalHeightIN * 2.54;

            // ** get age from user **
            System.Console.Write("Age: ");
            this.Age = int.Parse(System.Console.ReadLine());

            // ** get US Citizenship status from user **
            System.Console.Write("Is " + this.FirstName + " a US Citizen (Y/N)? ");
            string input = System.Console.ReadLine().ToLower();

            if (input.StartsWith("y"))
            {
                this.IsCitizen = true;
            }
        } // end GetDataFromUser method

        public string GetFullName()
        { // ** begin GetFullName method **

            string fullName;

            fullName = this.FirstName;
            fullName += " ";
            if (this.MiddleInitial != "")
            {
                fullName += this.MiddleInitial;
                fullName += ". ";
            }
            fullName += this.LastName;

            return fullName;
        } // ** end GetFullName method
    } // ** end of class Person
} // ** end of Lab1