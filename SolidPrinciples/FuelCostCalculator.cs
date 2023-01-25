using SolidPrinciples.Car;

namespace SolidPrinciples
{
    public class FuelCostCalculator
    {
        public double Calculate(BaseCar car)
        {
            return car.TripKM * car.GetCostPerKM();




            //Her yeni araç geldiğinde Open-Close prensipine ters düşer

            //Bunu Abstract yoluyla halledebildik

            //if (car is MercedesBenz)
            //{
            //    return car.TripKM * 2;
            //}
            //else if (car is BMW)
            //{
            //    return car.TripKM * 1.5;
            //}
            //return car.TripKM;
        }
    }
}
