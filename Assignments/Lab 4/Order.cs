﻿namespace Lab_4
{
    public class Order
    {
        private string Type;
        private int Adult;
        private int Child;
        private int Senior;
        private int SmallSoda;
        private int LargeSoda;
        private int Hotdog;
        private int Popcorn;
        private int Candy;

        static double smallSodaPrice = 3.50;
        static double largeSodaPrice = 5.99;
        static double hotdogPrice = 3.99;
        static double popcornPrice = 4.50;
        static double candyPrice = 1.99;


        public void FillOrder(string type)
        {
            this.Type = type;
            this.Adult = Gather.GetInt("adult tickets");
            this.Child = Gather.GetInt("child tickets");
            this.Senior = Gather.GetInt("senior tickets");
            this.SmallSoda = Gather.GetInt("small sodas");
            this.LargeSoda = Gather.GetInt("large sodas");
            this.Hotdog = Gather.GetInt("hotdogs");
            this.Popcorn = Gather.GetInt("popcorns");
            this.Candy = Gather.GetInt("candies");

            System.Console.WriteLine();
        }
        public double CalcPrice()
        {
            double orderCost = 0;
           
            orderCost += CalcTicketCost();
            orderCost += this.SmallSoda * Order.smallSodaPrice;
            orderCost += this.LargeSoda * Order.largeSodaPrice;
            orderCost += this.Popcorn * Order.popcornPrice;
            orderCost += this.Hotdog * Order.hotdogPrice;
            orderCost += this.Candy * Order.candyPrice;

            int tktpromo = this.Adult + this.Child + this.Senior;
            int poppromo = this.Popcorn;
            int sodapromo = this.LargeSoda;
            while ((poppromo > 0) && (sodapromo > 0) && (tktpromo > 0))
            {
                // $2 off for each popcorn and soda purchase
                orderCost -= 2;
                System.Console.WriteLine("** You qualify for a $2 discount **");
                poppromo -= 1;
                sodapromo -= 1;
                tktpromo -= 1;
            }

            tktpromo = this.Adult + this.Child + this.Senior;

            if (this.Type == "evening")
            {
                if (tktpromo > 2)
                {
                    System.Console.WriteLine("** You have earned one free popcorn **");
                 //   poppromo = this.Popcorn;
                    if (this.Popcorn > 1)
                    {
                        orderCost -= this.Popcorn;
                    }
                }
 
            }
            int candypromo = this.Candy;
            while (candypromo > 3)
            {
                System.Console.WriteLine("** Your 4th candy product is free **");
                orderCost -= Order.candyPrice;
                candypromo -= 4;
            }
            return orderCost;
        }

        public double CalcTicketCost()
        {
            double ticket = 0;
            //
            // default ticket prices to evening movie prices
            //
            double adult = 10.99;
            double child = 6.99;
            double senior = 8.50;

            if (this.Type == "matinee")
            {
                adult = 5.99;
                child = 3.99;
                senior = 4.50;
            }

            ticket += this.Adult * adult;
            ticket += this.Child * child;
            ticket += this.Senior * senior;
            return ticket;
        }

        public void PrintMovie(double orderCost)
        {
            System.Console.WriteLine("====== Order Summary ====== ");
            System.Console.WriteLine();
            System.Console.WriteLine("Movie Type: " + this.Type);
            System.Console.WriteLine("Adult Ticket: "+this.Adult);
            System.Console.WriteLine("Senior Ticket: " + this.Senior);
            System.Console.WriteLine("Child Ticket: " + this.Child);
            System.Console.WriteLine("Small Soda: " + this.SmallSoda);
            System.Console.WriteLine("Large Soda: " + this.LargeSoda);
            System.Console.WriteLine("Hot Dog: " + this.Hotdog);
            System.Console.WriteLine("Popcorn: " + this.Popcorn);
            System.Console.WriteLine("Candy: " + this.Candy);
            System.Console.WriteLine();
            System.Console.WriteLine("Order Cost: $" + orderCost);
            System.Console.WriteLine("===========================");
            System.Console.WriteLine();

        }
    }
}