namespace Lab_2
{
    class Person
    {
        // +==================================================================================+
        // | Member Variables for this.Person                                        |
        // +==================================================================================+  

        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;       // holds address of Spouse instance of this.Person if this.person is married

        // +==================================================================================+
        // | Static Class Variables for class Person                                          |
        // +==================================================================================+  

        public static double SumOfAllAges;
        public static int NbrPeople;

        // +==================================================================================+
        // | Constructor Method for class Person                                              |
        // +==================================================================================+  
        //

        public Person()
        {
            Person.NbrPeople++;
        }

        // +==================================================================================+
        // | Member Methods for this.Person                                                   |
        // +==================================================================================+  
        //
        public void GetData()
        {
          //  if (Spouse == null)
           // {
                // this = p1
                GetPersonData(null);
                if (GetIsMarried(this.FirstName) == true)
                {
                    GetSpouseData();
                  //  System.Console.WriteLine();
                }
     
           // }
            //else
            //{  // this = p1.spouse
            //      GetSpouseData("Spouse's");
              //  this.FirstName = GetFirstName("Spouse's ");
              //  this.LastName = this.Spouse.LastName;
              //  this.Age = GetAge();
            //}
        } // end GetData

        public void GetPersonData(string name)
        {
            this.FirstName = GetFirstName(name);
            if (name == null)
            {
                this.LastName = GetLastName(name);
            }
            else
            {
                this.LastName = this.Spouse.LastName;
               
            }
            this.Age = GetAge();
        }

        public void GetSpouseData()
        {
            this.Spouse = new Person();
            this.Spouse.Spouse = this;
            this.Spouse.GetPersonData("Spouse's ");
        }

        //public void GetSpouseData(string name)
        //{
        //    this.FirstName = GetFirstName(name);
        //    this.LastName = this.Spouse.LastName;
        //    this.Age = GetAge();
        // }

        public string GetFirstName(string name)
        {
            System.Console.Write(name + "First Name: ");
            return System.Console.ReadLine();

        }
        public string GetLastName(string name)
        {
            System.Console.Write(name + "Last Name: ");
            return System.Console.ReadLine();
        }

        public int GetAge()
        {
            System.Console.Write("Age: ");
            Age = int.Parse(System.Console.ReadLine());
            Person.SumOfAllAges += Age;
            return Age;
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
            System.Console.WriteLine(this.GetFullName() + " (Age " + this.Age + ")");
            if (this.Spouse != null)
            {
                System.Console.WriteLine(this.Spouse.GetFullName() + " (Age " + this.Spouse.Age + ")");
            }
            else
            {
                System.Console.WriteLine("(" + this.FirstName + " is not married.)");

            }
        }
    }
} 
