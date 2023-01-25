using System;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void CalculateTripCost()
        {
            var calculator = new FuelCostCalculator();

            var cost = calculator.Calculate(new Car.MercedesBenz());

            Console.WriteLine($"Total cost for this car is {cost} TL");
        }

        /*
         * ----------
         * 
         S ingle Responsibility Principle   (SRP) -Ok
         O open-Close Principle             (OCP)
         L iskov Substitution Principle     (LSP)
         I nterface Segregation Principle   (ISP)
         D ependency Inversion Principle    (DIP)
         *
         * ----------
         */
    }
}
