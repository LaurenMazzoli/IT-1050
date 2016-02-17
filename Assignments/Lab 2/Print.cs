namespace Lab_2
{
    class Print
    {
        public static void PersonHdr(string prompt)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("[ Enter Information for Person " + prompt + " ]");
        }

        public static void ResultHdr()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("****************** [ Program Results ] ******************");
        }
        public static void AvgAge()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Average Age: " + (Person.SumOfAllAges / Person.NbrPeople));
        }

        public static void ProgEnd()
        {
            System.Console.WriteLine();
            System.Console.Write("*************** [ Press any key to Exit ] ***************");
            System.Console.ReadKey();
        }

    }

} // end class Print
