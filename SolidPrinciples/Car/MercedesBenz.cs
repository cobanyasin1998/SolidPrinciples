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
    public class MercedesBenz : BaseCar, ISmsSendable, IEmailSendable
    {
        public override double GetCostPerKM()
        {
            return 2;
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
        public void SendTripInfoSmsToDriver(DriverInfo driverInfo)
        {
            if (!string.IsNullOrEmpty(driverInfo.PhoneNumber))
            {
                var smsSender = new SmsSender();
                smsSender.SendSms(new SmsModel()
                {
                    Message = "Todays Trip",
                    PhoneNumber = driverInfo.PhoneNumber,
                    SendTime = DateTime.Now
                });
            }
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped....");
        }

    }

}
