using SolidPrinciples.Car;
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




        public void RunCars()
        {
            try
            {
                var mercedes = new MercedesBenz();
                mercedes.Go();
                throw new EngineStartException();
                throw new AirPressureException();

                mercedes.Stop();

                mercedes.SendTripInfoEmailToDriver(new Models.DriverInfo());
            }
            catch (EngineStartException ex)
            {
                new TripInfoLogger(new GermanyLogger()).Log(ex.Message);
            }
            catch (AirPressureException ex)
            {
                new TripInfoLogger(new LocalStorageLogger()).Log(ex.Message);
            }
        }
       
    }


}
