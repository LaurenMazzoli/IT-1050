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
            Print.PersonHdr("1");
            p1.GetData();

            Person p2 = new Person();
            Print.PersonHdr("2");
            p2.GetData();

            Print.ResultHdr();            
            p1.PrintNameAndAge();
            p2.PrintNameAndAge();
            Print.AvgAge();
            // System.Console.WriteLine();
            // System.Console.WriteLine("Average Age: " + (Person.SumOfAllAges /Person.NbrPeople));

            Print.ProgEnd();
        } // end of main
    } //end of program
} // end of namespace 
