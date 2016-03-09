
namespace Lab_3
{
    public class Show
    {
        public static void Divider()
        {
            System.Console.WriteLine("==========================");

        }
        public static void Header()
        {
            System.Console.WriteLine(" == Student Information ==");
        }

        public static void Name(string type, string name)
        {
            System.Console.WriteLine(type + ": " + name);
        }
        public static void Grade(int grade)
        {
            System.Console.WriteLine("Grade: " + grade);
        }
        public static void ProgEnd()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to end...");
            System.Console.ReadKey();
        }
    }
}
