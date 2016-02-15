namespace Lab_2
{
    class Person
    {
        // +==================================================================================+
        // | Standard Member Variables for this.Person                                        |
        // +==================================================================================+  

        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;       // holds address of Spouse instance of this.Person if they are married

        // +==================================================================================+
        // | Static Class Variables for class Person                                           |
        // +==================================================================================+  

        public static double SumOfAllAges;

        public static int NbrPeople = 0;

        // +==================================================================================+
        // | Public Methods for this.Person                                                   |
        // +==================================================================================+  

        public string GetFullName()
        {
            string fullName = "";
            return fullName = this.FirstName + " " + this.LastName;
        } 

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName() + " is " + this.Age + " years old.");
        } 

    } // end class Person
} //end code
