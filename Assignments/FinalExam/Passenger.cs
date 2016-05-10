namespace FinalExam
{
    class Passenger
    { 
        private string Name;
        private double Weight;

        public Passenger(string name, double weight)
        {  // ** constructor method **

            this.Name = name;
            this.Weight = weight;

        } // ** end constructor **

        public string GetName()
        { // ** public method to set Name **
            return this.Name;
        }

        public double GetWeight()
        { // ** public method to set Weight **
            return this.Weight;
        }

    } // ** end of class Passenger **
}
