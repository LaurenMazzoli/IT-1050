namespace Lab_4
{    // +============================================================+
    // +   Course: IT-1050                                          +
    // +   Date: 3/28/16                                            +
    // +   Assigment: Lab 4                                         +
    // +   Name: Lauren Mazzoli                                     +
    // +============================================================+

    class Program
    {
        static void Main()
        {
            Order myMovie = new Order();
            //
            string movieType = Gather.MovieType();

            if (movieType != null)
            {
                double mycost = 0;
                myMovie.FillOrder(movieType);
                mycost = myMovie.CalcPrice();
                myMovie.PrintMovie(mycost);
 
            }
            else
            {
                System.Console.WriteLine("I guess you do not want to see a movie.");
            }

            System.Console.Write("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
