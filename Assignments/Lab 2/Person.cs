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
        //

        public void GetPersonData()
        {
         bool IsMarried=false;

            if (Spouse == null)
            {
                this.FirstName = GetFirstName();
                this.LastName = GetLastName();
                this.Age = GetAge();
                IsMarried = GetIsMarried(FirstName);
            }
            else
            {
                System.Console.Write("Spouse ");
                this.FirstName = GetFirstName();
                this.LastName = this.Spouse.LastName;
                System.Console.Write("Spouse ");
                this.Age = GetAge();
            }
            if (IsMarried)
            {
                Person s1 = new Person();
                this.Spouse = s1;
             }    
    } //end GetPersonData

    public string GetFirstName()
        {
            System.Console.Write("First Name: ");
            return System.Console.ReadLine();

        }
    public string GetLastName()
        {
            System.Console.Write("Last Name: ");
            return System.Console.ReadLine();
        }
    
    public int GetAge()
        {
            System.Console.Write("Age: ");
            return int.Parse(System.Console.ReadLine());
         }
    public string GetFullName()
         {
            string fullName;
            return fullName = FirstName + " " + LastName;
         }

    public bool GetIsMarried(string name)
     {
            bool isMarried = false;
            string married = null;

            while ((married != "Y") && (married != "N"))
            {
                System.Console.Write("Is " + name + " married (Y/N)? ");
                married = System.Console.ReadLine();
            }
            if (married == "Y")
                { 
                isMarried = true;
                }
            return isMarried;
      }
    public void PrintNameAndAge()
     {
            System.Console.WriteLine(this.GetFullName() + " Age " + this.Age);
     } 

    } // end class Person
} //end code
