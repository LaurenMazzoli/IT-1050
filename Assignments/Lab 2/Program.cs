namespace Lab_2
{
    // +============================================================+
    // +   Course: IT-1050                                          +
    // +   Date: 2/15/16                                            +
    // +   Assigment: Lab 2                                         +
    // +   Name: Lauren Mazzoli                                     +
    // +============================================================+
    class Program
    {
        static void Main(string[] args)
        {

            // +=======================+
            // +  create p1            +
            // +=======================+
            Person p1 = new Person();
            Person.NbrPeople++;
            System.Console.WriteLine("[ Enter Information for Person 1 ]");
            System.Console.WriteLine();
            p1.GetPersonData();
            Person.SumOfAllAges += p1.Age;
            if (p1.Spouse != null)
            {
                Person.NbrPeople++;
                p1.Spouse.Spouse = p1;
                p1.Spouse.GetPersonData();
                Person.SumOfAllAges += p1.Spouse.Age;
            }

            // +=======================+
            // +  create p2            +
            // +=======================+
            System.Console.WriteLine();
            System.Console.WriteLine("[ Enter Information for Person 2 ]");
            System.Console.WriteLine();
            Person p2 = new Person();
            Person.NbrPeople++;

            p2.GetPersonData();
            Person.SumOfAllAges += p2.Age;
            if (p2.Spouse != null)
            {
                Person.NbrPeople++;
                p2.Spouse.Spouse = p2;
                p2.Spouse.GetPersonData();
                Person.SumOfAllAges += p2.Spouse.Age;
            }

            // +=======================+
            // +  print person data    +
            // +=======================+
            System.Console.WriteLine();
            System.Console.WriteLine("[ Printing Results ]");
            System.Console.WriteLine();
            p1.PrintNameAndAge();
            if (p1.Spouse != null)
            {
                p1.Spouse.PrintNameAndAge();
            }
            else
            {
                System.Console.WriteLine("("+p1.FirstName + " is not married.)");
            }
        
            System.Console.WriteLine();
            p2.PrintNameAndAge();

            if (p2.Spouse != null)
             {
                p2.Spouse.PrintNameAndAge();
             }
            else
             {
                System.Console.WriteLine("(" + p2.FirstName + " is not married.)");
              }
            //
            // +===================================+
            // +     Print Summary Information     +
            // +===================================+
            //
            System.Console.WriteLine();
            System.Console.WriteLine("Average Age: " + (Person.SumOfAllAges /Person.NbrPeople));
            System.Console.WriteLine();
            System.Console.Write("Press any key to Exit...");
            System.Console.ReadKey();
        
        } // end of main
    } //end of program
} // end of namespace 
