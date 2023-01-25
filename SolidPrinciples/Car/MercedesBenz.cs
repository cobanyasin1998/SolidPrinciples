using SolidPrinciples.Models;
using SolidPrinciples.Models.SmsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Car
{
    public class MercedesBenz : BaseCar
    {
        public override double GetCostPerKM()
        {
            return 2;
        }

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
