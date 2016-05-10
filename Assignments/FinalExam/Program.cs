
namespace FinalExam
{
    // +============================================================+
    // +   Course: IT-1050                                          +
    // +   Date: 5/10/16                                            +
    // +   Assigment: Final                                         +
    // +   Name: Lauren Mazzoli                                     +
    // +============================================================+

    class Program
    {
        static void Main(string[] args)
        {
            #region elevator1Logic

                Elevator elevator1 = new Elevator(2,400);           // ** creates a new instance of Elevator called elevator1 **

                Passenger a1 = new Passenger("A1", 180);            // ** creates a new Passenger called a1 **  
                elevator1.AddOccupant(a1, 0);                       // ** adds Passenger a1 to elevator1's occupants (index 0) ** 

                elevator1.AddOccupant(new Passenger("A2", 220), 1); // ** creates a new Passenger, sets the values & adds it to elevator1's occupants (index 1) **

                bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity(); //** determines if the passenger weight of elevator1 is over its capacity **

            #endregion elevator1Logic

            #region elevator2Logic

                Elevator elevator2 = new Elevator(3, 600);          //  ** creates a new instance of Elevator called elevator2 **
            
                elevator2.AddOccupant(new Passenger("A1", 200), 0); //  ** creates a new Passenger, sets the values & adds it to elevator2's occupants (index 0) **
                elevator2.AddOccupant(new Passenger("A2", 200), 1); //  ** creates a new Passenger, sets the values & adds it to elevator2's occupants (index 1) **
                elevator2.AddOccupant(new Passenger("A3", 201), 2); //  ** creates a new Passenger, sets the values & adds it to elevator2's occupants (index 2) **

                bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity(); //** determines if the passenger weight of elevator2 is over its capacity **

            #endregion elevator2Logic
        }
    }
}
