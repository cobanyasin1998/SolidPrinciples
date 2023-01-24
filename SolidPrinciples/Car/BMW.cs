using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Car
{
    public class BMW : BaseCar
    {
        public int TripKM { get; set; }
        public void Go()
        {
            Console.WriteLine("Car is now going....");
        }
        public void Stop()
        {
            Console.WriteLine("Car has stopped....");
        }
    }
}
