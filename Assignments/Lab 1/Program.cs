namespace Lab_1
{
    class Program
    { // ** begin class Program **
        static void Main(string[] args)
        { // ** begin Main method**

            // ** instansiate a new object of type Person  **   
            Person newPerson = new Person();

            // ** invoke void public method GetDataFromUser on class Person to populate member variabes of newPerson **
            newPerson.GetDataFromUser();

            // ** determine if the newPerson can vote **
            bool canVote;
            if (newPerson.IsCitizen && newPerson.Age > 18)
            {
                canVote = true;
            }
            else
            {
                canVote = false;
            }

            //** invoke PrintResults static void method on class Program to print newPerson data to Console **
            PrintResults(newPerson, canVote);

        } // ** end Main method **

        static void PrintResults(Person NewPerson, bool CanVote)
        {
            //** call method GetFullName on class Person to return a formatted name **
            System.Console.WriteLine();
            System.Console.WriteLine("*******************************");
            System.Console.WriteLine("Name entered: " + NewPerson.GetFullName());
            System.Console.WriteLine("Height (CM): " + NewPerson.TotalHeightCM);
            string prompt = " is ";
            if (CanVote == false)
            {
                prompt += "not ";
            }

            prompt += "eligible to vote.";
            System.Console.WriteLine(NewPerson.FirstName + prompt);
            System.Console.ReadKey();
        }
    }
}