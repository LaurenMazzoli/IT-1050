namespace Lab_4
{
    public class Gather
    {

        public static string GetMovieType()
        {
            string movieType = "matinee";
            string input = Gather.GetString(movieType);

            if (input != "y")
            {

                movieType = "evening";
                input = Gather.GetString(movieType);
  
                if (input != "y") 
                {
                    movieType = null;
                }
            }
            return movieType;
        }
        public static string GetString(string prompt)
        {
            System.Console.Write("Enter 'Y' if you want to see a "+ prompt + " movie: ");
            string input = System.Console.ReadLine().ToLower();
           // input = input.ToLower();
            return input;
            //        return string input = System.Console.ReadLine().ToLower();
         }

        public static int GetInt(string prompt)
        {
            //bool inputInt = false;
            string input=null;
            int value = 0;

            while (!(int.TryParse(input,out value)))
            { 
                System.Console.Write("How many " + prompt + " would you like? ");
                input = System.Console.ReadLine();
            }
            //  return int.Parse(System.Console.ReadLine());
            return value;
         }               
    }
}
