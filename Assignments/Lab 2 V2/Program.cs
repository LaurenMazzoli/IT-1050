
namespace Lab_2_V2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            GetData(p1);

            Person p2 = new Person();
            GetData(p2);

            System.Console.WriteLine("+++++++++++++ Results +++++++++++++++");
            PrintData(p1);
            PrintData(p2);
            PrintAvgAge();

            // ** calculate and print average age **



        } // end main

        public static void GetData(Person p)
        {
            bool isMarried = false;

            isMarried = p.GetPersonData(null);
            if (isMarried)
            {
                p.Spouse = new Person();
                p.Spouse.Spouse = p;
                p.Spouse.LastName = p.LastName;
                p.Spouse.GetPersonData("Spouse ");
            }
            System.Console.WriteLine();
        } // end GetSpouseData

        public static void PrintData(Person p)
        {
            p.PrintNameAndAge("");
            if (p.Spouse != null)
            {
                p.Spouse.PrintNameAndAge("Spouse ");
            }
            System.Console.WriteLine();
        } // end PrintData Method

        public static void PrintAvgAge()
        {
            double avgAge = Person.SumOfAllAges / Person.NbrPeople;
            System.Console.WriteLine("Average Age: " + avgAge);
            System.Console.ReadLine();

        } // end PrintAvg method
    } 
}
