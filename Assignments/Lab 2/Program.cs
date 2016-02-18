namespace Lab_2
{
    // +============================================================+
    // +   Course: IT-1050                                          +
    // +   Date: 2/17/16                                            +
    // +   Assigment: Lab 2                                         +
    // +   Name: Lauren Mazzoli                                     +
    // +============================================================+
    class Program
    {
        static void Main(string[] args)
        {

            // +===============================================+
            // |       Variable Assignment                     |
            // +===============================================+

            Person.NbrPeople = 0;
            Person.SumOfAllAges = 0;

            // +===============================================+
            // |       Main Code                               |
            // +===============================================+

            Person p1 = new Person();
            Print.PersonHdr("1");
            p1.GetData();

            Person p2 = new Person();
            Print.PersonHdr("2");
            p2.GetData();

            // +===============================================+
            // |       Print Results                           |
            // +===============================================+

            Print.ResultHdr();
            p1.PrintPersonData();    
            p2.PrintPersonData();
            Print.AverageAge();
            Print.ProgEnd();

        } // end of main 

    } // end of program

} // end of namespace lab2
