namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

          //  bool isMarried = false;
            string married = null;
            Person p1 = new Person();

            // Get name data

            p1.FirstName = "Lauren";
            p1.LastName = "Mazzoli";
            p1.Age = 50;
            p1.Spouse = null;
            Person.NbrPeople++;
            p1.PrintNameAndAge();
            Person.SumOfAllAges += p1.Age;

            // get marital data

            while ((married != "Y") && (married != "N"))
            {
                System.Console.Write("Hi " + p1.FirstName + ", Are you married (Y/N)?");
                married = System.Console.ReadLine();
            }
            //  isMarried = bool.Parse(System.Console.ReadLine());
            if (married == "Y")
            //          if (isMarried)
            {
                Person s1 = new Person();
                p1.Spouse = s1;
                s1.FirstName = "Lou";
                s1.LastName = p1.LastName;
                s1.Age = 48;
                Person.NbrPeople++;

                System.Console.WriteLine("Your spouse is: " + s1.GetFullName() + ".");
                s1.PrintNameAndAge();
                Person.SumOfAllAges += s1.Age;
                s1.Spouse = p1;
                // s1.GetSpouseData();
            }
            else
            {
                System.Console.WriteLine("You have no Spouse.");
            }
            Person p2 = new Person();
            p2.FirstName = "Carolyn";
            p2.LastName = "Mecenas";
            p2.Age = 53;
            p2.PrintNameAndAge();
            Person.SumOfAllAges += p2.Age;
            p2.Spouse = null;
            married = null;
            Person.NbrPeople++;

            while ((married != "Y") && (married != "N"))
            {
                System.Console.Write("Hi " + p2.FirstName + ", Are you married (Y/N)?");
                married = System.Console.ReadLine();
            }
            //isMarried= bool.Parse(System.Console.ReadLine());
           if (married == "Y")
            {
                Person s2 = new Person();
                s2.FirstName = "Mark";
                s2.LastName = p2.LastName;
                s2.Age = 55;
                s2.Spouse = p2;
                p2.Spouse = s2;
                Person.NbrPeople++;
                System.Console.WriteLine("Your spouse is: " + s2.GetFullName() + ". ");
                s2.PrintNameAndAge();
                Person.SumOfAllAges += s2.Age;
                // s2.GetSpouseData
                //
            }
        else
            {
                System.Console.WriteLine("You have no Spouse.");
            }

            System.Console.WriteLine("Total Sum of all Ages: " + Person.SumOfAllAges);
            System.Console.WriteLine("Total Nbr of People: " + Person.NbrPeople);
            System.Console.WriteLine("The Average Age is: " + (Person.SumOfAllAges /Person.NbrPeople));
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadLine();
        
        }
    }
}
