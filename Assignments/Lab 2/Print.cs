﻿namespace Lab_2
{
    class Print
    {
        public static void PersonHdr(string prompt)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("[ Enter Information for Person " + prompt + " ]");
            System.Console.WriteLine();
        }

        public static void ResultHdr()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("****************** [ Program Results ] ******************");
            System.Console.WriteLine();
        }
        public static void AverageAge()
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
} 