

namespace Lab_2_V2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;
        public static int NbrPeople;

        public Person()
        {
            Person.NbrPeople++;
            this.Spouse =null;
        }

        public bool GetPersonData(string prompt)
        {

            System.Console.Write(prompt + "First Name: ");
            this.FirstName = System.Console.ReadLine();
            if (this.Spouse == null)
            {
                System.Console.Write("Last Name: ");
                this.LastName = System.Console.ReadLine();
            }
            System.Console.Write(prompt+"Age: ");
            this.Age = int.Parse(System.Console.ReadLine());

            SumOfAllAges += this.Age;

            bool isMarried = false;

            if (this.Spouse == null)
            {
                isMarried=GetMarriageStatus();
            }
            return isMarried;
        }

        public bool GetMarriageStatus()
        {
            bool status = false;
            System.Console.Write("Married (Y/N): ");
            string input = System.Console.ReadLine().ToLower();

            if (input.StartsWith("y"))
            {
                status = true;
            }
            return status;
        }

        public string GetFullName()
        {
        return  this.FirstName+ " "+ this.LastName;
        }

        public void PrintNameAndAge(string Prompt)
        {
            System.Console.WriteLine(Prompt + "Name: " + GetFullName());
            System.Console.WriteLine(Prompt+ "Age: " + this.Age);

        }
     }
}
