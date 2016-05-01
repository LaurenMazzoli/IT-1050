
namespace Lab_2_V2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            Person p2 = new Person();

            bool isMarried = false;
            //string prompt = null

            isMarried = p1.GetPersonData(null);
            if (isMarried)
            {
                p1.Spouse = new Person();
                p1.Spouse.Spouse = p1;
                p1.Spouse.LastName = p1.LastName;
                p1.Spouse.GetPersonData("Spouse ");
            }
            System.Console.WriteLine();

            isMarried = p2.GetPersonData(null);
            if (isMarried)
            {
                p2.Spouse = new Person();
                p2.Spouse.Spouse = p2;
                p2.Spouse.LastName = p2.LastName;
                p2.Spouse.GetPersonData("Spouse ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("+++++++++++++ Results +++++++++++++++");
            p1.PrintNameAndAge("");
            if (p1.Spouse != null)
            {
                p1.Spouse.PrintNameAndAge("Spouse ");
            }
            System.Console.WriteLine();
            p2.PrintNameAndAge("");

            if (p2.Spouse != null)
            {
                p2.Spouse.PrintNameAndAge("Spouse ");
            }
            double averageAge = Person.SumOfAllAges / Person.NbrPeople;
            System.Console.Write("Average Age: " + averageAge);
            System.Console.ReadLine();
        } // end main
    } 
}
