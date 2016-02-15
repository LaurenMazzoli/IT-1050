namespace Assignment1
{
    //  CLASS IT 1050 PROGRAMMING LOGIC
    // ASSIGNMENT 1: LAUREN MAZZOLI 2/2/16
    //
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARE VARIABLES

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;

            int age;
            int heightFeet;

            bool isCitizen = false;
            bool canVote = false;

            double heightInches;
            double totalHeightCM;

            // MAIN BODY OF CODE

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your Last Name? ");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + ". " + lastName;

            System.Console.Write("What is your base height in feet? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches beyond your base height are you? ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = (((heightFeet * 12) + heightInches) * 2.54);

            System.Console.Write("What is your age in years? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Type \'true\' if you are a US citizen and type \'false\' if you are not. ");
            isCitizen = bool.Parse(System.Console.ReadLine());
          
            if (isCitizen && age > 17)
                canVote = true;

            System.Console.WriteLine();
            System.Console.WriteLine("Your name is " + fullName + ".");
            System.Console.WriteLine("Your height is " + totalHeightCM + " centimeters.");
            System.Console.WriteLine("\'You are eligible to vote.\' is a " + canVote + " statement.");

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();

        }

    }
}
