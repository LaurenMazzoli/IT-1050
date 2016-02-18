namespace Lab_2
{
    class Person
    {
        // +==================================================================================+
        // | Member Variables for this.Person                                                 |
        // +==================================================================================+  

        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;    

        // +==================================================================================+
        // | Static Class Variables for Person                                                |
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
                GetPersonData(null);
                if (GetIsMarried(this.FirstName) == true)
                {
                    GetSpouseData();
                }
        } 

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
            this.Spouse.GetPersonData("Spouse ");
        } 

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
            while (int.TryParse(System.Console.ReadLine(), out Age) == false)
            {
                System.Console.Write("Age: ");
            } 
            Person.SumOfAllAges += Age;
            return Age;
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

        public void PrintPersonData()
        {
            this.PrintNameAndAge();
            if (this.Spouse != null)
            {
                this.Spouse.PrintNameAndAge();
            }
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName()+"\t" + " (Age " + this.Age + ")");
        }

        public string GetFullName()
        {
            string fullName;
            return fullName = FirstName + " " + LastName;
        }
    } // end Person
}