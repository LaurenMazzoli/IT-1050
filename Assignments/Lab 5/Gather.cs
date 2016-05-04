
namespace Lab_5
{
    public class Gather
    {
        public static string GetString(string prompt)
        {
            prompt += ": ";
            string input = "";
            while (input == "")
            {
                System.Console.Write(prompt);
                input = System.Console.ReadLine();
                input = input.Trim();
            }
            return input;
        } // end GetString method

        public static int GetInt(string prompt)
        { // get int from user

            string input = null;
            int value = 0;

            while (!(int.TryParse(input, out value)))
            {
                System.Console.Write(prompt + ": ");
                input = System.Console.ReadLine();
            }

            return value;
        } // end method GetInt 

        public static bool GetBool(string prompt)
        {

            prompt += ": ";

            string input = "x";
    
            while ( (!input.StartsWith("y")) && (!input.StartsWith("n")) )
            {
                System.Console.Write(prompt);     
                input = System.Console.ReadLine().ToLower();

            }

            bool isOK = true;
            if (input.StartsWith("n"))
            {
                isOK = false;
            }
            return isOK;
        } // end method GetBool
    } // end class Gather
}
