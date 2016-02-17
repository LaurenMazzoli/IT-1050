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
            Person.NbrPeople = 0;
            Person.SumOfAllAges = 0;

            Person p1 = new Person();
            p1.GetPersonData("p1");

            Person p2 = new Person();
            p2.GetPersonData("p2");

            System.Console.WriteLine();
            System.Console.WriteLine("[ Printing Results ]");
            p1.PrintNameAndAge();
            p2.PrintNameAndAge();
            System.Console.WriteLine();
            System.Console.WriteLine("Average Age: " + (Person.SumOfAllAges /Person.NbrPeople));
            System.Console.WriteLine();
            System.Console.Write("Press any key to Exit...");
            System.Console.ReadKey();
        
        } // end of main
    } //end of program
} // end of namespace 
