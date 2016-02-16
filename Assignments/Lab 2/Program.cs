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
            System.Console.WriteLine("Person 2");
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
            System.Console.Write("Person 1 ");
            p1.PrintNameAndAge();
            if (p1.Spouse != null)
            {
                System.Console.WriteLine();
                System.Console.Write("Spouse ");
                p1.Spouse.PrintNameAndAge();
            }
            else
            {
                System.Console.WriteLine();
                System.Console.WriteLine("("+p1.FirstName + " is not married.)");
            }
        
            System.Console.WriteLine();
            System.Console.Write("Person 2 ");
            p2.PrintNameAndAge();

            if (p2.Spouse != null)
             {
                System.Console.WriteLine();
                System.Console.Write("Spouse ");
                p2.Spouse.PrintNameAndAge();
             }
            else
             {
                System.Console.WriteLine();
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
            System.Console.WriteLine("Press any key to Exit...");
            System.Console.WriteLine();
            System.Console.ReadKey();
        
        } // end of main
    } //end of program
} // end of namespace 
