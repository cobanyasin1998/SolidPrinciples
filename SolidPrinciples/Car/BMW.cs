using SolidPrinciples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Car
{
    public class BMW : BaseCar, IEmailSendable
    {

        public override double GetCostPerKM()
        {
            return 1.5;
        }

        public void Go()
        {
            Console.WriteLine("Car is now going....");
        }

        public void SendTripInfoEmailToDriver(DriverInfo driverInfo)
        {
            if (!string.IsNullOrEmpty(driverInfo.EmailAddress))
            {
                var mailMessage = new MailMessage();
                mailMessage.To.Add(driverInfo.EmailAddress);

                var client = new SmtpClient("mail.mercedes.com", 587);
                client.Send(mailMessage);
            }
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped....");
        }
    }
}
