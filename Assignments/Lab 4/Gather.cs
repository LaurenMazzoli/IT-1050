namespace Lab_4
{
    public class Gather
    {

        public static string MovieType()
        {
            string movietype = null;
            System.Console.Write("Enter 'Y' if you want to see a matinee: ");
            string input = System.Console.ReadLine().ToLower();
            // System.Console.WriteLine();

            if (input == "y")
            {
                movietype = "matinee";
            }
            else
            {
                System.Console.Write("Enter 'Y' if you want to see an evening movie: ");
                input = System.Console.ReadLine().ToLower();
               //  System.Console.WriteLine();

                if (input == "y")
                {
                    movietype = "evening";
                }
            }
            return movietype;
        }
     
        public static int NbrItems(string input)
        { 
            System.Console.Write("How many " + input + "s would you like? ");
            return int.Parse(System.Console.ReadLine());
        }               
    }
}
