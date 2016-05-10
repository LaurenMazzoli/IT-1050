namespace FinalExam
{
    class Elevator
    {
   
        private double MaxWeight;       
        private Passenger[] Occupants; // ** defines an array of type Passenger  **
      
        public Elevator(int maxOccupants, double maxWeight)
        { // constructor method

            this.MaxWeight = maxWeight;                 
            this.Occupants = new Passenger[maxOccupants]; // ** creates memory for array of size maxOccupants
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            this.Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double currentWeight = 0;

            for (int i = 0; i < Occupants.Length; i++)
            {
                currentWeight += this.Occupants[i].GetWeight();
            }
            return currentWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return this.GetCurrentWeight() > this.MaxWeight;
        }
    } // end class Elevator
}
